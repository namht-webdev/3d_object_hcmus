using System.Collections.Generic;
using SharpGL;
using System;
namespace testCk
{
    // lớp hình lăng trụ tam giác kế thừa lớp objects
    class prism : objects
    {
        public static int _countPrism = 0;// đếm số lăng trụ được tạo ra
        public prism()
        {
            _countPrism++;
            this.name = "Prism " + _countPrism;
            listVertex = new List<vertex>();
            // Lấy tọa độ các điểm của tam giác đều mặt phẳng Oxz
            double x1, x2, x3, z1, z2, z3;
            x1 = 0.5 * Math.Cos(0*Math.PI/180);
            z1 = 0.5 * Math.Sin(0 * Math.PI / 180);
            x2 = 0.5 * Math.Cos(120 * Math.PI / 180);
            z2 = 0.5 * Math.Sin(120 * Math.PI / 180);
            x3 = 0.5 * Math.Cos(240 * Math.PI / 180);
            z3 = 0.5 * Math.Sin(240 * Math.PI / 180);



            // hình tam giác phía trên của lăng trụ
            listVertex.Add(new vertex(x1, 0.5f, z1));
            listVertex.Add(new vertex(x2, 0.5f, z2));
            listVertex.Add(new vertex(x3, 0.5f, z3));

            // hình tam giác phía dưới của lăng trụ

            listVertex.Add(new vertex(x1, -0.5f, z1));
            listVertex.Add(new vertex(x2, -0.5f, z2));
            listVertex.Add(new vertex(x3, -0.5f, z3));

            // hình vuông bên trái phía trước của lăng trụ
            listVertex.Add(new vertex(x1, 0.5f, z1));
            listVertex.Add(new vertex(x3, 0.5f, z3));
            listVertex.Add(new vertex(x3, -0.5f, z3));
            listVertex.Add(new vertex(x1, -0.5f, z1));


            // hình vuông bên phải phía trước của lăng trụ
            listVertex.Add(new vertex(x1, 0.5f, z1));
            listVertex.Add(new vertex(x2, 0.5f, z2));
            listVertex.Add(new vertex(x2, -0.5f, z2));
            listVertex.Add(new vertex(x1, -0.5f, z1));

            // hình vuông phía sau của lăng trụ
            listVertex.Add(new vertex(x2, 0.5f, z2));
            listVertex.Add(new vertex(x3, 0.5f, z3));
            listVertex.Add(new vertex(x3, -0.5f, z3));
            listVertex.Add(new vertex(x2, -0.5f, z2));
        }
        public override void Draw(OpenGL gl)
        {
            //vẽ 2 đáy tam giác đều
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
            for (int i = 0; i < 6; i++)
            {
                gl.Vertex(listVertex[i].x, listVertex[i].y, listVertex[i].z);
            }
            gl.End();
            //vẽ các mặt bên của lăng trụ
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
            for (int i = 6; i < listVertex.Count; i++)
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

            // từ đỉnh 0
            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z);
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);

            // từ đỉnh 1
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);

            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z);
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);

            // từ đỉnh 2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z);
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z);

            // từ đỉnh 3
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);

            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z);
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z);

            // từ đỉnh 4
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z);
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z);


            gl.End();
        }
    }
}
