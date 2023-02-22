namespace Student_management_system
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.F_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Signup = new System.Windows.Forms.Button();
            this.F_close = new System.Windows.Forms.Button();
            this.F_Minimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.F_Maximize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(145, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERA";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.F_Login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.F_Signup);
            this.panel1.Location = new System.Drawing.Point(87, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 502);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // F_Login
            // 
            this.F_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.F_Login.BackColor = System.Drawing.Color.Gold;
            this.F_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.F_Login.Location = new System.Drawing.Point(263, 399);
            this.F_Login.Name = "F_Login";
            this.F_Login.Size = new System.Drawing.Size(102, 35);
            this.F_Login.TabIndex = 3;
            this.F_Login.Text = "Login";
            this.F_Login.UseVisualStyleBackColor = false;
            this.F_Login.Click += new System.EventHandler(this.F_Login_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(77, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to\r\nOpera Institute\r\nStudent Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // F_Signup
            // 
            this.F_Signup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.F_Signup.BackColor = System.Drawing.Color.Gold;
            this.F_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Signup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.F_Signup.Location = new System.Drawing.Point(92, 399);
            this.F_Signup.Name = "F_Signup";
            this.F_Signup.Size = new System.Drawing.Size(102, 35);
            this.F_Signup.TabIndex = 2;
            this.F_Signup.Text = "Sign up";
            this.F_Signup.UseVisualStyleBackColor = false;
            this.F_Signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_close
            // 
            this.F_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_close.BackColor = System.Drawing.Color.Tomato;
            this.F_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.F_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F_close.Image = ((System.Drawing.Image)(resources.GetObject("F_close.Image")));
            this.F_close.Location = new System.Drawing.Point(620, 1);
            this.F_close.Name = "F_close";
            this.F_close.Size = new System.Drawing.Size(26, 26);
            this.F_close.TabIndex = 2;
            this.F_close.UseVisualStyleBackColor = false;
            this.F_close.Click += new System.EventHandler(this.button3_Click);
            // 
            // F_Minimize
            // 
            this.F_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.F_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("F_Minimize.Image")));
            this.F_Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.F_Minimize.Location = new System.Drawing.Point(558, 1);
            this.F_Minimize.Name = "F_Minimize";
            this.F_Minimize.Size = new System.Drawing.Size(26, 26);
            this.F_Minimize.TabIndex = 3;
            this.F_Minimize.UseVisualStyleBackColor = true;
            this.F_Minimize.Click += new System.EventHandler(this.F_Minimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.F_Maximize);
            this.panel2.Controls.Add(this.F_close);
            this.panel2.Controls.Add(this.F_Minimize);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 30);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.F_mouseDown_Event);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.F_mouseMove_Event);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.F_mouseUp_Event);
            // 
            // F_Maximize
            // 
            this.F_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.F_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("F_Maximize.Image")));
            this.F_Maximize.Location = new System.Drawing.Point(590, 1);
            this.F_Maximize.Name = "F_Maximize";
            this.F_Maximize.Size = new System.Drawing.Size(26, 26);
            this.F_Maximize.TabIndex = 5;
            this.F_Maximize.UseVisualStyleBackColor = true;
            this.F_Maximize.Click += new System.EventHandler(this.button4_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opera Institution";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button F_Signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button F_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button F_close;
        private System.Windows.Forms.Button F_Minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button F_Maximize;
    }
}

