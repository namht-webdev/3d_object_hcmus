using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using System.Windows.Forms;

namespace _18120438_18120466_18120521_BT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.openGLControl.DrawFPS =
            true;
            openGLControl.Resized +=
                       new EventHandler(openGLControl_Resized);
            FormClosing +=
                       new FormClosingEventHandler(Form1_FormClosing);
        }

        void Form1_FormClosing(
                   object sender, FormClosingEventArgs e)
        {
            openGLControl.OpenGL.DeleteTextures(1, textures);
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            SharpGL.OpenGL gl = this.openGLControl.OpenGL;

            gl.Enable(OpenGL.GL_BLEND);
            gl.Disable(OpenGL.GL_DEPTH_TEST);

            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Ortho2D(0.0, openGLControl.Width, openGLControl.Height, 0);


            // ...
            //  We need to load the texture from file.
            textureImage =
                       new Bitmap(
                       "Crate.bmp");


            //  A bit of extra initialisation here, we have to enable textures.
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            gl.TexEnv(OpenGL.GL_TEXTURE_ENV, OpenGL.GL_TEXTURE_ENV_MODE, OpenGL.GL_REPLACE);


            //  Get one texture id, and stick it into the textures array.
            gl.GenTextures(1, textures);


            //  Bind the texture.
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, textures[0]);


            //  Tell OpenGL where the texture data is.
            gl.TexImage2D(OpenGL.GL_TEXTURE_2D, 0, 3, textureImage.Width, textureImage.Height, 0, OpenGL.GL_BGR, OpenGL.GL_UNSIGNED_BYTE,
                textureImage.LockBits(
                       new Rectangle(0, 0, textureImage.Width, textureImage.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb).Scan0);


            //  Specify linear filtering.
            gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MIN_FILTER, OpenGL.GL_LINEAR);
            gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MAG_FILTER, OpenGL.GL_LINEAR);
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Ortho2D(0.0, openGLControl.Width, openGLControl.Height, 0);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl =
                    this.openGLControl.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();

            gl.BindTexture(OpenGL.GL_TEXTURE_2D, textures[0]);

            gl.Begin(OpenGL.GL_QUADS);
            {

                // Top Left Of The Texture and Quad
                gl.TexCoord(0.0f, 0.0f);
                gl.Vertex(0.0, 1.0f, 0.0f);


                // Bottom Left Of The Texture and Quad
                gl.TexCoord(0.0f, 1.0f);
                gl.Vertex(0.0, 0.0, 0.0f);


                // Bottom Right Of The Texture and Quad
                gl.TexCoord(1.0f, 1.0f);
                gl.Vertex(1.0f, 0.0, 0.0f);


                // Top Right Of The Texture and Quad
                gl.TexCoord(1.0f, 0.0f);
                gl.Vertex(1.0f, 1.0f, 0.0f);
            }
            gl.End();

            gl.Flush();
        }
        //  The texture identifier.
        uint[] textures =
        new
        uint[1];


        //  Storage the texture itself.
        Bitmap textureImage;
    }
}
