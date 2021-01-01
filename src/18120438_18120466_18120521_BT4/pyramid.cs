using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace testCk
{
    // lớp hình chóp tứ giác kế thừa lớp objects
    class pyramid : objects
    {

        public static int _countPyramid = 0;// đếm số hình chóp được tạo ra
        public pyramid()
        {
            _countPyramid++;
            this.name = "Pyramid " + _countPyramid;
            listVertex = new List<vertex>();


            // hình vuông đáy chóp
            listVertex.Add(new vertex(0.5f, -0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, 0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, 0.5f));

            // mặt phía trước bên trái
            listVertex.Add(new vertex(0.0f, 0.5f, 0.0f));
            listVertex.Add(new vertex(-0.5f, -0.5f, 0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, 0.5f));

            // mặt phía trước bên phải
            listVertex.Add(new vertex(0.0f, 0.5f, 0.0f));
            listVertex.Add(new vertex(0.5f, -0.5f, 0.5f)); 
            listVertex.Add(new vertex(0.5f, -0.5f, -0.5f));



            // mặt phía sau bên trái
            listVertex.Add(new vertex(0.0f, 0.5f, 0.0f));
            listVertex.Add(new vertex(-0.5f, -0.5f, 0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, -0.5f));

            // mặt phía sau bên phải
            listVertex.Add(new vertex(0.0f, 0.5f, 0.0f));
            listVertex.Add(new vertex(-0.5f, -0.5f, -0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, -0.5f));
        }
        public override void Draw(OpenGL gl)
        {

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
            for (int i = 0; i < 4; i++)
            {
                gl.Vertex(listVertex[i].x, listVertex[i].y, listVertex[i].z);
            }
            gl.End();

            // vẽ hình chóp bằng cách ghép các tam giác
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
            for (int i = 4; i < listVertex.Count; i++)
            {
                gl.Vertex(listVertex[i].x, listVertex[i].y, listVertex[i].z);
            }
            gl.End();
        }

        public override void ShowBorder(OpenGL gl)
        {
            gl.Color(1.0f, 165.0 / 255f, 0.0f);
            gl.LineWidth(3);
            gl.Begin(OpenGL.GL_LINES);

            // Từ đỉnh 0
            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);

            // từ đỉnh 2

            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);

            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);

            // từ đỉnh chóp(đỉnh 4)
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);
            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);

            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);

            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);

            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);

            gl.End();
        }

        public override void DrawTexture(OpenGL gl)
        {
            // chuyển về màu trắng để không bị đè lẫn màu với texture
            _color = Color.Transparent;
            Update(gl);
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            //Bind the texture.
            texture.Bind(gl);
            gl.Begin(OpenGL.GL_QUADS);     

            double delta = 0.005;


            ////mặt dưới
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[0].x + delta, listVertex[0].y - delta, listVertex[0].z - delta);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[1].x - delta, listVertex[1].y - delta, listVertex[1].z - delta);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[2].x - delta, listVertex[2].y - delta, listVertex[2].z + delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[3].x + delta, listVertex[3].y - delta, listVertex[3].z + delta);

            // mặt phía trước trái
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[4].x, listVertex[4].y + delta, listVertex[4].z); // V1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[4].x - delta, listVertex[4].y - delta, listVertex[4].z + delta); // V1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[5].x + delta, listVertex[5].y - delta, listVertex[5].z + delta); // V3
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[6].x, listVertex[6].y, listVertex[6].z); // V4

            // mặt trước bên phải
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[7].x, listVertex[7].y + delta, listVertex[7].z); // V1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[7].x + delta, listVertex[7].y - delta, listVertex[7].z + delta); // V1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[8].x + delta, listVertex[8].y - delta, listVertex[8].z - delta); // V2
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[9].x, listVertex[9].y, listVertex[9].z); // V3

            //mặt phía sau bên trái
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[10].x, listVertex[10].y + delta, listVertex[10].z);
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[10].x - delta, listVertex[10].y - delta, listVertex[10].z + delta);
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[11].x - delta, listVertex[11].y - delta, listVertex[11].z - delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[12].x, listVertex[12].y, listVertex[12].z);

            // mặt phía sau bên phải
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[13].x, listVertex[13].y + delta, listVertex[13].z);
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[13].x - delta, listVertex[13].y - delta, listVertex[13].z - delta);
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[14].x + delta, listVertex[14].y - delta, listVertex[14].z - delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[15].x, listVertex[15].y, listVertex[15].z);


            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }

    }
}
