using System.Collections.Generic;
using SharpGL;
using System.Drawing;
using System;
using SharpGL.SceneGraph.Assets;

namespace testCk
{
    class objects
    {
        public List<vertex> listVertex; // danh sách tất cả đỉnh của object
        public Color _color; // màu nền
        public string name; // tên khi đối tượng tạo ra

        public float angleX, angleY, angleZ;
        public double tX, tY, tZ;
        public double sX, sY, sZ;

        public bool isTexture;
        public Texture texture;

        public objects()
        {
            _color = Color.White;
            tX = tY = tZ = 0.0f;
            angleX = angleY = angleZ = 0.0f;
            sX = sY = sZ = 1.0f;
        }

        public virtual void Draw(OpenGL gl)
        {

        }

        public virtual void ShowBorder(OpenGL gl)
        {

        }

        public virtual void DrawTexture(OpenGL gl)
        {

        }

        // cập nhật các thay đổi trên đối tượng
        public virtual void Update(OpenGL gl)
        {
            for (int i = 0; i < listVertex.Count; i++)
            {
                listVertex[i].x += tX;
                listVertex[i].y += tY;
                listVertex[i].z += tZ;
            }
            tX = tY = tZ = 0;


            // thay đổi kích thước
            for (int i = 0; i < listVertex.Count; i++)
            {
                listVertex[i].x *= sX;
                listVertex[i].y *= sY;
                listVertex[i].z *= sZ;
            }
            sX = sY = sZ = 1.0;

            // thay đổi góc xoay

            gl.Rotate(angleX, angleY, angleZ);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
