namespace testCk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openGLControl = new SharpGL.OpenGLControl();
            this.treeView = new System.Windows.Forms.TreeView();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xRot = new System.Windows.Forms.TextBox();
            this.xScale = new System.Windows.Forms.TextBox();
            this.yPos = new System.Windows.Forms.TextBox();
            this.zScale = new System.Windows.Forms.TextBox();
            this.zRot = new System.Windows.Forms.TextBox();
            this.zPos = new System.Windows.Forms.TextBox();
            this.yScale = new System.Windows.Forms.TextBox();
            this.yRot = new System.Windows.Forms.TextBox();
            this.xPos = new System.Windows.Forms.TextBox();
            this.btn_OkT = new System.Windows.Forms.Button();
            this.shape = new System.Windows.Forms.RichTextBox();
            this.btn_Pyramid = new System.Windows.Forms.Button();
            this.btn_Prism = new System.Windows.Forms.Button();
            this.btn_Cube = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Color = new System.Windows.Forms.Button();
            this.paintDialog = new System.Windows.Forms.ColorDialog();
            this.btn_OkR = new System.Windows.Forms.Button();
            this.btn_OkS = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yCam = new System.Windows.Forms.Label();
            this.zCam = new System.Windows.Forms.Label();
            this.xCam = new System.Windows.Forms.Label();
            this.btn_Texture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(178, 0);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(837, 608);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView.LineColor = System.Drawing.Color.MidnightBlue;
            this.treeView.Location = new System.Drawing.Point(1015, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(248, 147);
            this.treeView.TabIndex = 4;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox.Enabled = false;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Items.AddRange(new object[] {
            "\t       Transform",
            "",
            "Position",
            "",
            "Rotarion",
            "",
            "Scale"});
            this.listBox.Location = new System.Drawing.Point(1015, 172);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(248, 139);
            this.listBox.TabIndex = 5;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(1070, 207);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(14, 13);
            this.label0.TabIndex = 6;
            this.label0.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1070, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1070, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1182, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1182, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1182, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1126, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1126, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1126, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Y";
            // 
            // xRot
            // 
            this.xRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xRot.Location = new System.Drawing.Point(1087, 234);
            this.xRot.Multiline = true;
            this.xRot.Name = "xRot";
            this.xRot.Size = new System.Drawing.Size(28, 19);
            this.xRot.TabIndex = 16;
            this.xRot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xScale
            // 
            this.xScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xScale.Location = new System.Drawing.Point(1087, 263);
            this.xScale.Multiline = true;
            this.xScale.Name = "xScale";
            this.xScale.Size = new System.Drawing.Size(28, 19);
            this.xScale.TabIndex = 17;
            this.xScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yPos
            // 
            this.yPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPos.Location = new System.Drawing.Point(1143, 205);
            this.yPos.Multiline = true;
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(28, 19);
            this.yPos.TabIndex = 18;
            this.yPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zScale
            // 
            this.zScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zScale.Location = new System.Drawing.Point(1199, 263);
            this.zScale.Multiline = true;
            this.zScale.Name = "zScale";
            this.zScale.Size = new System.Drawing.Size(28, 19);
            this.zScale.TabIndex = 19;
            this.zScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zRot
            // 
            this.zRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zRot.Location = new System.Drawing.Point(1199, 234);
            this.zRot.Multiline = true;
            this.zRot.Name = "zRot";
            this.zRot.Size = new System.Drawing.Size(28, 19);
            this.zRot.TabIndex = 20;
            this.zRot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zPos
            // 
            this.zPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zPos.Location = new System.Drawing.Point(1199, 205);
            this.zPos.Multiline = true;
            this.zPos.Name = "zPos";
            this.zPos.Size = new System.Drawing.Size(28, 19);
            this.zPos.TabIndex = 21;
            this.zPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yScale
            // 
            this.yScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yScale.Location = new System.Drawing.Point(1143, 263);
            this.yScale.Multiline = true;
            this.yScale.Name = "yScale";
            this.yScale.Size = new System.Drawing.Size(28, 19);
            this.yScale.TabIndex = 22;
            this.yScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yRot
            // 
            this.yRot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yRot.Location = new System.Drawing.Point(1142, 234);
            this.yRot.Multiline = true;
            this.yRot.Name = "yRot";
            this.yRot.Size = new System.Drawing.Size(28, 19);
            this.yRot.TabIndex = 23;
            this.yRot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xPos
            // 
            this.xPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPos.Location = new System.Drawing.Point(1087, 205);
            this.xPos.Multiline = true;
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(28, 19);
            this.xPos.TabIndex = 15;
            this.xPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_OkT
            // 
            this.btn_OkT.Location = new System.Drawing.Point(1230, 203);
            this.btn_OkT.Name = "btn_OkT";
            this.btn_OkT.Size = new System.Drawing.Size(31, 23);
            this.btn_OkT.TabIndex = 24;
            this.btn_OkT.Text = "OK";
            this.btn_OkT.UseVisualStyleBackColor = true;
            this.btn_OkT.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // shape
            // 
            this.shape.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.shape.Enabled = false;
            this.shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shape.Location = new System.Drawing.Point(1, 0);
            this.shape.Name = "shape";
            this.shape.ReadOnly = true;
            this.shape.Size = new System.Drawing.Size(81, 248);
            this.shape.TabIndex = 25;
            this.shape.Text = "   Shapes";
            // 
            // btn_Pyramid
            // 
            this.btn_Pyramid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Pyramid.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pyramid.Image")));
            this.btn_Pyramid.Location = new System.Drawing.Point(7, 26);
            this.btn_Pyramid.Name = "btn_Pyramid";
            this.btn_Pyramid.Size = new System.Drawing.Size(70, 75);
            this.btn_Pyramid.TabIndex = 26;
            this.btn_Pyramid.UseVisualStyleBackColor = false;
            this.btn_Pyramid.Click += new System.EventHandler(this.btn_Pyramid_Click);
            // 
            // btn_Prism
            // 
            this.btn_Prism.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Prism.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prism.Image")));
            this.btn_Prism.Location = new System.Drawing.Point(7, 99);
            this.btn_Prism.Name = "btn_Prism";
            this.btn_Prism.Size = new System.Drawing.Size(70, 75);
            this.btn_Prism.TabIndex = 27;
            this.btn_Prism.UseVisualStyleBackColor = false;
            this.btn_Prism.Click += new System.EventHandler(this.btn_Prism_Click);
            // 
            // btn_Cube
            // 
            this.btn_Cube.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Cube.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cube.Image")));
            this.btn_Cube.Location = new System.Drawing.Point(7, 172);
            this.btn_Cube.Name = "btn_Cube";
            this.btn_Cube.Size = new System.Drawing.Size(70, 75);
            this.btn_Cube.TabIndex = 28;
            this.btn_Cube.UseVisualStyleBackColor = false;
            this.btn_Cube.Click += new System.EventHandler(this.btn_Cube_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(91, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(81, 249);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "Properties";
            // 
            // btn_Color
            // 
            this.btn_Color.Image = ((System.Drawing.Image)(resources.GetObject("btn_Color.Image")));
            this.btn_Color.Location = new System.Drawing.Point(97, 49);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(70, 75);
            this.btn_Color.TabIndex = 30;
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_OkR
            // 
            this.btn_OkR.Location = new System.Drawing.Point(1230, 232);
            this.btn_OkR.Name = "btn_OkR";
            this.btn_OkR.Size = new System.Drawing.Size(31, 23);
            this.btn_OkR.TabIndex = 31;
            this.btn_OkR.Text = "OK";
            this.btn_OkR.UseVisualStyleBackColor = true;
            this.btn_OkR.Click += new System.EventHandler(this.btn_OkR_Click);
            // 
            // btn_OkS
            // 
            this.btn_OkS.Location = new System.Drawing.Point(1230, 261);
            this.btn_OkS.Name = "btn_OkS";
            this.btn_OkS.Size = new System.Drawing.Size(31, 23);
            this.btn_OkS.TabIndex = 32;
            this.btn_OkS.Text = "OK";
            this.btn_OkS.UseVisualStyleBackColor = true;
            this.btn_OkS.Click += new System.EventHandler(this.btn_OkS_Click);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.Color.Lime;
            this.x.Location = new System.Drawing.Point(189, 9);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(20, 15);
            this.x.TabIndex = 33;
            this.x.Text = "X:";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.ForeColor = System.Drawing.Color.Blue;
            this.y.Location = new System.Drawing.Point(189, 29);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(19, 15);
            this.y.TabIndex = 34;
            this.y.Text = "Y:";
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.z.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.ForeColor = System.Drawing.Color.Red;
            this.z.Location = new System.Drawing.Point(189, 49);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(19, 15);
            this.z.TabIndex = 35;
            this.z.Text = "Z:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(211, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 36;
            // 
            // yCam
            // 
            this.yCam.AutoSize = true;
            this.yCam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yCam.ForeColor = System.Drawing.Color.Blue;
            this.yCam.Location = new System.Drawing.Point(211, 29);
            this.yCam.Name = "yCam";
            this.yCam.Size = new System.Drawing.Size(0, 15);
            this.yCam.TabIndex = 37;
            // 
            // zCam
            // 
            this.zCam.AutoSize = true;
            this.zCam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zCam.ForeColor = System.Drawing.Color.Red;
            this.zCam.Location = new System.Drawing.Point(211, 49);
            this.zCam.Name = "zCam";
            this.zCam.Size = new System.Drawing.Size(0, 15);
            this.zCam.TabIndex = 38;
            // 
            // xCam
            // 
            this.xCam.AutoSize = true;
            this.xCam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xCam.ForeColor = System.Drawing.Color.Lime;
            this.xCam.Location = new System.Drawing.Point(211, 9);
            this.xCam.Name = "xCam";
            this.xCam.Size = new System.Drawing.Size(0, 15);
            this.xCam.TabIndex = 39;
            // 
            // btn_Texture
            // 
            this.btn_Texture.Image = ((System.Drawing.Image)(resources.GetObject("btn_Texture.Image")));
            this.btn_Texture.Location = new System.Drawing.Point(97, 130);
            this.btn_Texture.Name = "btn_Texture";
            this.btn_Texture.Size = new System.Drawing.Size(70, 70);
            this.btn_Texture.TabIndex = 40;
            this.btn_Texture.UseVisualStyleBackColor = true;
            this.btn_Texture.Click += new System.EventHandler(this.btn_Texture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1264, 601);
            this.Controls.Add(this.btn_Texture);
            this.Controls.Add(this.xCam);
            this.Controls.Add(this.zCam);
            this.Controls.Add(this.yCam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.z);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.btn_OkS);
            this.Controls.Add(this.btn_OkR);
            this.Controls.Add(this.btn_Color);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Cube);
            this.Controls.Add(this.btn_Prism);
            this.Controls.Add(this.btn_Pyramid);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.btn_OkT);
            this.Controls.Add(this.yRot);
            this.Controls.Add(this.yScale);
            this.Controls.Add(this.zPos);
            this.Controls.Add(this.zRot);
            this.Controls.Add(this.zScale);
            this.Controls.Add(this.yPos);
            this.Controls.Add(this.xScale);
            this.Controls.Add(this.xRot);
            this.Controls.Add(this.xPos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.openGLControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(-6, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xRot;
        private System.Windows.Forms.TextBox xScale;
        private System.Windows.Forms.TextBox yPos;
        private System.Windows.Forms.TextBox zScale;
        private System.Windows.Forms.TextBox zRot;
        private System.Windows.Forms.TextBox zPos;
        private System.Windows.Forms.TextBox yScale;
        private System.Windows.Forms.TextBox yRot;
        private System.Windows.Forms.TextBox xPos;
        private System.Windows.Forms.Button btn_OkT;
        private System.Windows.Forms.RichTextBox shape;
        private System.Windows.Forms.Button btn_Pyramid;
        private System.Windows.Forms.Button btn_Prism;
        private System.Windows.Forms.Button btn_Cube;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.ColorDialog paintDialog;
        private System.Windows.Forms.Button btn_OkR;
        private System.Windows.Forms.Button btn_OkS;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label yCam;
        private System.Windows.Forms.Label zCam;
        private System.Windows.Forms.Label xCam;
        private System.Windows.Forms.Button btn_Texture;
    }
}

