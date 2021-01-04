using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SharpGL.SceneGraph.Assets;
using SharpGL;


namespace testCk
{
    public partial class Form1 : Form
    {
        bool isPrism = false; // kiểm tra đối tượng đang được chọn có là lăng trụ không?
        OpenFileDialog stickTexture = new OpenFileDialog(); // cho phép mở thư mục lấy ảnh
        Camera cam = new Camera(); // lớp camera
        int posObject = -1; // lấy vị trí của đối tượng khi được chọn
        TreeNode rootObj; // cây chứa danh sách tên các đối tượng được tạo ra
        List<objects> objs = new List<objects>(); // danh sách các đối tượng được tạo ra
        objects obj; // đối tượng mới khởi tạo
        public Form1()
        {

            InitializeComponent();
            loadTreeView();

        }

        // vẽ trục tọa độ Oxyz trong không gian
        private void DrawCoord(OpenGL gl)
        {
            //OpenGL gl = openGLControl.OpenGL;
            gl.LineWidth(3.0f);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(0.0f, 1.0f, 0.0f); // màu xanh lục
            gl.Vertex(-50.0f, 0.0f, 0.0f);
            gl.Vertex(50.0f, 0.0f, 0.0f); // Ox
            gl.Color(0.0f, 0.0f, 1.0f);  // màu xanh lam
            gl.Vertex(0.0f, -30.0f, 0.0f);
            gl.Vertex(0.0f, 30.0f, 0.0f); // Oy
            gl.Color(1.0f, 0.0f, 0.0f);  // màu đỏ
            gl.Vertex(0.0f, 0.0f, -50.0f);
            gl.Vertex(0.0f, 0.0f, 50.0f); // Oz
            gl.End();

            // Vẽ lưới tọa độ đơn vị 0.5
            gl.Color(1.0f, 1.0f, 1.0);
            gl.LineWidth(1.0f);
            gl.Begin(OpenGL.GL_LINES);

            // Vẽ lưới trên trục Ox với độ dài 100 và 100 đường mỗi bên
            for (float i = -50.0f; i < 50.0f; i += 0.5f)
            {
                if (i != 0)
                {
                    gl.Vertex(-50.0f, 0.0f, i);
                    gl.Vertex(50.0f, 0.0f, i);
                }
            }
            // Vẽ lưới trên trục Oz với độ dài 100 và 100 đường mỗi bên
            for (float i = -50.0f; i < 50.0f; i += 0.5f)
            {
                if (i != 0)
                {
                    gl.Vertex(i, 0.0f, -50.0f);
                    gl.Vertex(i, 0.0f, 50.0f);
                }
            }

            gl.End();
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            // Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {

            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the ModelView matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);

            //  Use the 'look at' helper function to position and aim the camera.
            gl.LookAt(cam._eyeX, cam._eyeY, cam._eyeZ, cam._lookX, cam._lookY, cam._lookZ, 0, 1, 0);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Create a perspective transformation.
            gl.Perspective(60, openGLControl.Width * 1f / openGLControl.Height, 1, 50);
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            // Load the identity.
            gl.LoadIdentity();
            // Create a perspective transformation.
            gl.LookAt(cam._eyeX, cam._eyeY, cam._eyeZ, cam._lookX, cam._lookY, cam._lookZ, 0, 1, 0);
            DrawCoord(gl);

            // xác định vị trí và góc nhìn của camera
            xCam.Text = Math.Round(cam._eyeX, 3).ToString();
            yCam.Text = Math.Round(cam._eyeY, 3).ToString();
            zCam.Text = Math.Round(cam._eyeZ, 3).ToString();

            for (int i = 0; i < objs.Count; i++)
            {
                objs[i].Update(gl);
                objs[i].Draw(gl);
                if (objs[i].isTexture)
                    objs[i].DrawTexture(gl);
            }
            if (posObject != -1)
            {
                //objs[posObject].angleX += 10;
                //objs[posObject].angleY += 10;
                //objs[posObject].angleZ += 10;
                objs[posObject].ShowBorder(gl);
            }

            gl.Flush();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            OpenGL gl = openGLControl.OpenGL;

            // Các nút điều khiển góc nhìn của Camera
            if (keyData == Keys.Z)
                cam.ZoomIn();
            if (keyData == Keys.X)
                cam.ZoomOut();
            if (keyData == Keys.Left)
                cam.RotateLeft();
            if (keyData == Keys.Right)
                cam.RotateRight();
            if (keyData == Keys.Up)
                cam.RotateUp();
            if (keyData == Keys.Down)
                cam.RotateDown();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // nút 'ok' đồng ý thay đổi trên đối tượng
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // các thay đổi trên đối tượng khi click
            double tx, ty, tz;
            if (posObject != -1) // kiểm tra đối tượng đang chọn cần thay đổi
            {
                // ép kiểu dữ liệu về dạng double để thay đổi trên đối tượng
                // thay đổi vị trí
                bool issucessTx = Double.TryParse(xPos.Text.ToString(), out tx);
                bool issucessTy = Double.TryParse(yPos.Text.ToString(), out ty);
                bool issucessTz = Double.TryParse(zPos.Text.ToString(), out tz);
                // ép kiểu thành công => thay đổi vị trí đối tượng
                if (issucessTx && issucessTx && issucessTz)
                {
                    objs[posObject].tX = tx;
                    objs[posObject].tY = ty;
                    objs[posObject].tZ = tz;
                }
            }
            else MessageBox.Show("Chon doi tuong truoc khi thao tac");
        }


        private void btn_OkR_Click(object sender, EventArgs e)
        {
            float rx, ry, rz;
            if (posObject != -1) // kiểm tra đối tượng đang chọn cần thay đổi
            {
                // ép kiểu dữ liệu về dạng double để thay đổi trên đối tượng
                // thay đổi vị trí
                bool issucessRx = float.TryParse(xRot.Text.ToString(), out rx);
                bool issucessRy = float.TryParse(yRot.Text.ToString(), out ry);
                bool issucessRz = float.TryParse(zRot.Text.ToString(), out rz);
                // ép kiểu thành công => thay đổi vị trí đối tượng
                if (issucessRx && issucessRx && issucessRz)
                {
                   
                        objs[posObject].angleX += rx;
                        objs[posObject].angleY += ry;
                        objs[posObject].angleZ += rz;
                   
                }

            }
            else MessageBox.Show("Chon doi tuong truoc khi thao tac");
        }

        private void btn_OkS_Click(object sender, EventArgs e)
        {
            double sx, sy, sz;
            if (posObject != -1) // kiểm tra đối tượng đang chọn cần thay đổi
            {
                // ép kiểu dữ liệu về dạng double để thay đổi trên đối tượng
                // thay đổi vị trí
                bool issucessSx = Double.TryParse(xScale.Text.ToString(), out sx);
                bool issucessSy = Double.TryParse(yScale.Text.ToString(), out sy);
                bool issucessSz = Double.TryParse(zScale.Text.ToString(), out sz);
                // ép kiểu thành công => thay đổi vị trí đối tượng
                if (issucessSx && issucessSx && issucessSz)
                {
                        objs[posObject].sX = sx;
                        objs[posObject].sY = sy;
                        objs[posObject].sZ = sz;

                }

            }
            else MessageBox.Show("Chon doi tuong truoc khi thao tac");
        }
        // khởi tạo hình chóp khi click vào biểu tượng chóp
        private void btn_Pyramid_Click(object sender, EventArgs e)
        {
            posObject = -1;
            obj = new pyramid();
            rootObj.Nodes.Add(obj.name);
            objs.Add(obj);
        }
        // khởi tạo lăng trụ khi click vào biểu tượng lăng trụ 
        private void btn_Prism_Click(object sender, EventArgs e)
        {
            posObject = -1;
            obj = new prism();
            rootObj.Nodes.Add(obj.name);
            objs.Add(obj);
        }
        // khởi tạo khối lập khi click vào biểu tượng lập phương
        private void btn_Cube_Click(object sender, EventArgs e)
        {
            posObject = -1;
            obj = new cube();
            rootObj.Nodes.Add(obj.name);
            objs.Add(obj);
        }


        // bắt sự kiện click vào đối tượng đượng chọn trong khung hiển thị tên đối tượng
        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Font fB = new Font(treeView.Font, FontStyle.Bold);
            Font fR = new Font(treeView.Font, FontStyle.Regular);

            for (int i = 0; i < objs.Count; i++)
            {
                if (e.Node.Text.Equals(objs[i].name))
                {
                    int x = i + 1;
                    string s = "Prism " + x.ToString();
                    if (objs[i].name.Equals(s))
                    {
                        isPrism = true;
                    }
                    else isPrism = false;
                    // lấy index của đối tượng được chọn lưu vào posObject
                    posObject = i;

                    if (e.Node.Checked == true)
                        e.Node.NodeFont = fB; // bôi đen đối ượng được click
                    else
                        e.Node.NodeFont = fR; // đối tượng không được click thì vẫn bình thường
                }
            }

        }


        // bảng hiện thị các đối tượng được tạo ra thành dạng cây thư mục
        private void loadTreeView()
        {
            rootObj = new TreeNode();//khởi tạo cây thư mục
            rootObj.Text = "Object"; // gốc cây thư mục
            treeView.Nodes.Add(rootObj);
            treeView.NodeMouseClick += TreeView_NodeMouseClick; // tạo sự kiện click vào node trên bảng
        }


        // bảng chọn màu của đối tượng
        private void btn_Color_Click(object sender, EventArgs e)
        {
            if (posObject == -1)
                MessageBox.Show("Chon doi tuong truoc khi thao tac"); // Chọn đối tượng trước khi thao tác
            //lấy màu từ paintDialog gán cho đối tượng được chỉ điểm
            else if (paintDialog.ShowDialog() == DialogResult.OK)
            {
                if (posObject != -1)
                    objs[posObject]._color = paintDialog.Color;

            }
        }

        private void btn_Texture_Click(object sender, EventArgs e)
        {
            if (posObject != -1)
            {
                if (isPrism) MessageBox.Show("Chua ho tro chuc nang nay cho lang tru"); // chưa hỗ trợ chức năng dán texture cho lăng trụ
                else if (stickTexture.ShowDialog() == DialogResult.OK)
                {
                    string path = stickTexture.FileName.ToString(); // đường dẫn đến ảnh chọn làm texture
                    Texture texture = new Texture(); // tạo mới texture
                    bool issucess = texture.Create(openGLControl.OpenGL, path); // lấy ảnh làm texture từ đường dẫn

                    if (issucess)
                    {
                        objs[posObject].texture = texture; // dán texture cho đối tượng
                        objs[posObject].isTexture = true; // bật đã dán texture
                    }
                }
            }
            else
                MessageBox.Show("Chon doi tuong truoc khi thao tac");
        }

    }
}
