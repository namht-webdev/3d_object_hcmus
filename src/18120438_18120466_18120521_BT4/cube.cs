using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;
using System.Drawing;
using SharpGL.SceneGraph;

namespace testCk
{

    // lớp hình lập phương kế thừa lớp objects
    class cube : objects
    {
        public static int _countCube = 0;// đếm số lập phương được tạo ra
        // mặc định hình vẽ ban đầu ở gốc tọa độ
        public cube()
        {
            _countCube++;
            listVertex = new List<vertex>();
            this.name = "Cube " + _countCube;
            // vẽ các mặt xung quanh của khối lập phương bằng các hình vuông

            // hình vuông phía trên của khối lập phương
            listVertex.Add(new vertex(0.5f, 0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, 0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, 0.5f, 0.5f));
            listVertex.Add(new vertex(0.5f, 0.5f, 0.5f));

            // hình vuông phía dưới của khối lập phương
            listVertex.Add(new vertex(0.5f, -0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, 0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, 0.5f));

            //// hình vuông phía sau bên phải lập phương
            listVertex.Add(new vertex(0.5f, 0.5f, 0.5f));
            listVertex.Add(new vertex(-0.5f, 0.5f, 0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, 0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, 0.5f));


            // hình vuông phía sau bên trái lập phương
            listVertex.Add(new vertex(0.5f, 0.5f, -0.5f));
            listVertex.Add(new vertex(0.5f, 0.5f, 0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, 0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, -0.5f));



            // hình vuông mặt trước bên phải của khối lập phương
            listVertex.Add(new vertex(-0.5f, 0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, 0.5f, 0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, 0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, -0.5f));

            //// hình vuông mặt trước bên trái của khối lập phương
            listVertex.Add(new vertex(0.5f, 0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, 0.5f, -0.5f));
            listVertex.Add(new vertex(-0.5f, -0.5f, -0.5f));
            listVertex.Add(new vertex(0.5f, -0.5f, -0.5f));

        }

        public override void ShowBorder(OpenGL gl)
        {
            gl.Color(1.0f, 165.0/255f, 0.0f);
            gl.LineWidth(3);
            gl.Begin(OpenGL.GL_LINES);

            // Từ đỉnh 0
            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);

            // Từ đỉnh 1
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);

            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z);

            // Từ đỉnh 2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);

            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);
            gl.Vertex(listVertex[6].x, listVertex[6].y, listVertex[6].z);

            // từ đỉnh 3
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);
            gl.Vertex(listVertex[7].x, listVertex[7].y, listVertex[7].z);

            // từ đỉnh 4
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z);

            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);
            gl.Vertex(listVertex[7].x, listVertex[7].y, listVertex[7].z);

            // từ đỉnh 6
            gl.Vertex(listVertex[6].x, listVertex[6].y, listVertex[6].z);
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z);

            gl.Vertex(listVertex[6].x, listVertex[6].y, listVertex[6].z);
            gl.Vertex(listVertex[7].x, listVertex[7].y, listVertex[7].z);
            gl.End();
        }

        // hàm vẽ các hình vuông quanh khối lập phương
        public override void Draw(OpenGL gl)
        {
            // vẽ tứ giác
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
            for (int i = 0; i < listVertex.Count; i++)
            {
                gl.Vertex(listVertex[i].x, listVertex[i].y, listVertex[i].z);
            }
            gl.End();

        }

        public override void DrawTexture(OpenGL gl)
        {
            // chuyển về màu trắng để không bị đè lẫn màu với texture
            _color = Color.Transparent;
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            //Bind the texture.
            texture.Bind(gl);
            gl.Begin(OpenGL.GL_QUADS);


            double delta = 0.005;
            
            // mặt trên
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[0].x + delta, listVertex[0].y + delta, listVertex[0].z - delta);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[1].x - delta, listVertex[1].y + delta, listVertex[1].z - delta);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[2].x - delta, listVertex[2].y + delta, listVertex[2].z + delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[3].x + delta, listVertex[3].y + delta, listVertex[3].z + delta);

            ////mặt dưới
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[4].x + delta, listVertex[4].y - delta, listVertex[4].z - delta);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[5].x - delta, listVertex[5].y - delta, listVertex[5].z - delta);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[6].x - delta, listVertex[6].y - delta, listVertex[6].z + delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[7].x + delta, listVertex[7].y - delta, listVertex[7].z + delta);

            // mặt sau phía bên phải
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[8].x + delta, listVertex[8].y + delta, listVertex[8].z + delta);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[9].x - delta, listVertex[9].y + delta, listVertex[9].z + delta);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[10].x - delta, listVertex[10].y - delta, listVertex[10].z + delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[11].x + delta, listVertex[11].y - delta, listVertex[11].z + delta);

            // mặt sau phía bên trái
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[12].x + delta, listVertex[12].y + delta, listVertex[12].z - delta);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[13].x + delta, listVertex[13].y + delta, listVertex[13].z + delta);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[14].x + delta, listVertex[14].y - delta, listVertex[14].z + delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[15].x + delta, listVertex[15].y - delta, listVertex[15].z - delta);

            // mặt trước bên phải
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[16].x - delta, listVertex[16].y + delta, listVertex[16].z - delta);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[17].x - delta, listVertex[17].y + delta, listVertex[17].z + delta);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[18].x - delta, listVertex[18].y - delta, listVertex[18].z + delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[19].x - delta, listVertex[19].y - delta, listVertex[19].z - delta);

            // mặt trước bên phải
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[20].x + delta, listVertex[20].y + delta, listVertex[20].z - delta);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[21].x - delta, listVertex[21].y + delta, listVertex[21].z - delta);
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[22].x - delta, listVertex[22].y - delta, listVertex[22].z - delta);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[23].x + delta, listVertex[23].y - delta, listVertex[23].z - delta);

            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);
        }

    }
}
