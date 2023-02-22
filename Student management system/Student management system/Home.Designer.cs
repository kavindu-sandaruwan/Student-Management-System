namespace Student_management_system
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.H_Maximize = new System.Windows.Forms.Button();
            this.H_close = new System.Windows.Forms.Button();
            this.H_Minimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Homebutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Logout = new System.Windows.Forms.Button();
            this.Teacherdetails = new System.Windows.Forms.Button();
            this.Studentdetails = new System.Windows.Forms.Button();
            this.Subjectdetails = new System.Windows.Forms.Button();
            this.Addstudents = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Subject_Details1 = new Student_management_system.UserControls.UC_Subject_Details();
            this.uC_TeacherDetails1 = new Student_management_system.UserControls.UC_TeacherDetails();
            this.uC_New_Student1 = new Student_management_system.UserControls.UC_New_Student();
            this.uC_Homepanel1 = new Student_management_system.UserControls.UC_Homepanel();
            this.uC_Student_Details1 = new Student_management_system.UserControls.UC_Student_Details();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.H_Maximize);
            this.panel2.Controls.Add(this.H_close);
            this.panel2.Controls.Add(this.H_Minimize);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1420, 30);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H_MouseDown_Event);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.H_MouseMove_Event);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.H_MouseUp_Event);
            // 
            // H_Maximize
            // 
            this.H_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.H_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.H_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.H_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("H_Maximize.Image")));
            this.H_Maximize.Location = new System.Drawing.Point(1361, 1);
            this.H_Maximize.Name = "H_Maximize";
            this.H_Maximize.Size = new System.Drawing.Size(26, 26);
            this.H_Maximize.TabIndex = 5;
            this.H_Maximize.UseVisualStyleBackColor = true;
            this.H_Maximize.Click += new System.EventHandler(this.F_Maximize_Click);
            // 
            // H_close
            // 
            this.H_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.H_close.BackColor = System.Drawing.Color.Tomato;
            this.H_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.H_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.H_close.Image = ((System.Drawing.Image)(resources.GetObject("H_close.Image")));
            this.H_close.Location = new System.Drawing.Point(1391, 1);
            this.H_close.Name = "H_close";
            this.H_close.Size = new System.Drawing.Size(26, 26);
            this.H_close.TabIndex = 2;
            this.H_close.UseVisualStyleBackColor = false;
            this.H_close.Click += new System.EventHandler(this.F_close_Click);
            // 
            // H_Minimize
            // 
            this.H_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.H_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.H_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.H_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("H_Minimize.Image")));
            this.H_Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.H_Minimize.Location = new System.Drawing.Point(1329, 1);
            this.H_Minimize.Name = "H_Minimize";
            this.H_Minimize.Size = new System.Drawing.Size(26, 26);
            this.H_Minimize.TabIndex = 3;
            this.H_Minimize.UseVisualStyleBackColor = true;
            this.H_Minimize.Click += new System.EventHandler(this.H_Minimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Homebutton);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Teacherdetails);
            this.panel1.Controls.Add(this.Studentdetails);
            this.panel1.Controls.Add(this.Subjectdetails);
            this.panel1.Controls.Add(this.Addstudents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 745);
            this.panel1.TabIndex = 6;
            // 
            // Homebutton
            // 
            this.Homebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Homebutton.AnimatedGIF = true;
            this.Homebutton.BackColor = System.Drawing.Color.Gold;
            this.Homebutton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Homebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homebutton.Image = ((System.Drawing.Image)(resources.GetObject("Homebutton.Image")));
            this.Homebutton.ImageOffset = new System.Drawing.Point(0, 0);
            this.Homebutton.ImageRotate = 0F;
            this.Homebutton.ImageSize = new System.Drawing.Size(40, 40);
            this.Homebutton.Location = new System.Drawing.Point(39, 130);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Homebutton.ShadowDecoration.BorderRadius = 20;
            this.Homebutton.ShadowDecoration.Color = System.Drawing.Color.Gold;
            this.Homebutton.Size = new System.Drawing.Size(40, 40);
            this.Homebutton.TabIndex = 14;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Logout.BackColor = System.Drawing.Color.SteelBlue;
            this.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(39, 670);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(245, 46);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "            Log out";
            this.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Teacherdetails
            // 
            this.Teacherdetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Teacherdetails.BackColor = System.Drawing.Color.SteelBlue;
            this.Teacherdetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Teacherdetails.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Teacherdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacherdetails.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacherdetails.ForeColor = System.Drawing.Color.White;
            this.Teacherdetails.Image = ((System.Drawing.Image)(resources.GetObject("Teacherdetails.Image")));
            this.Teacherdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Teacherdetails.Location = new System.Drawing.Point(39, 386);
            this.Teacherdetails.Name = "Teacherdetails";
            this.Teacherdetails.Size = new System.Drawing.Size(245, 46);
            this.Teacherdetails.TabIndex = 9;
            this.Teacherdetails.Text = "            Teachers Details";
            this.Teacherdetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Teacherdetails.UseVisualStyleBackColor = false;
            this.Teacherdetails.Click += new System.EventHandler(this.button3_Click);
            // 
            // Studentdetails
            // 
            this.Studentdetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Studentdetails.BackColor = System.Drawing.Color.SteelBlue;
            this.Studentdetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Studentdetails.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Studentdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Studentdetails.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentdetails.ForeColor = System.Drawing.Color.White;
            this.Studentdetails.Image = ((System.Drawing.Image)(resources.GetObject("Studentdetails.Image")));
            this.Studentdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Studentdetails.Location = new System.Drawing.Point(39, 296);
            this.Studentdetails.Name = "Studentdetails";
            this.Studentdetails.Size = new System.Drawing.Size(245, 46);
            this.Studentdetails.TabIndex = 9;
            this.Studentdetails.Text = "            Students Details";
            this.Studentdetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Studentdetails.UseVisualStyleBackColor = false;
            this.Studentdetails.Click += new System.EventHandler(this.Studentdetails_Click);
            // 
            // Subjectdetails
            // 
            this.Subjectdetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Subjectdetails.BackColor = System.Drawing.Color.SteelBlue;
            this.Subjectdetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Subjectdetails.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Subjectdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subjectdetails.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subjectdetails.ForeColor = System.Drawing.Color.White;
            this.Subjectdetails.Image = ((System.Drawing.Image)(resources.GetObject("Subjectdetails.Image")));
            this.Subjectdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subjectdetails.Location = new System.Drawing.Point(39, 483);
            this.Subjectdetails.Name = "Subjectdetails";
            this.Subjectdetails.Size = new System.Drawing.Size(245, 46);
            this.Subjectdetails.TabIndex = 10;
            this.Subjectdetails.Text = "            Subjects Details";
            this.Subjectdetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subjectdetails.UseVisualStyleBackColor = false;
            this.Subjectdetails.Click += new System.EventHandler(this.Subjectdetails_Click);
            // 
            // Addstudents
            // 
            this.Addstudents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Addstudents.BackColor = System.Drawing.Color.SteelBlue;
            this.Addstudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Addstudents.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Addstudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addstudents.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addstudents.ForeColor = System.Drawing.Color.White;
            this.Addstudents.Image = ((System.Drawing.Image)(resources.GetObject("Addstudents.Image")));
            this.Addstudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addstudents.Location = new System.Drawing.Point(39, 204);
            this.Addstudents.Name = "Addstudents";
            this.Addstudents.Size = new System.Drawing.Size(245, 46);
            this.Addstudents.TabIndex = 8;
            this.Addstudents.Text = "            Add New Student";
            this.Addstudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addstudents.UseVisualStyleBackColor = false;
            this.Addstudents.Click += new System.EventHandler(this.Addstudents_Click);
            this.Addstudents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Addstudents_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1420, 100);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(114, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Institute For Higher Education";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(101, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 71);
            this.label1.TabIndex = 8;
            this.label1.Text = "OPERA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 0;
            // 
            // uC_Subject_Details1
            // 
            this.uC_Subject_Details1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Subject_Details1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.uC_Subject_Details1.Location = new System.Drawing.Point(318, 127);
            this.uC_Subject_Details1.Name = "uC_Subject_Details1";
            this.uC_Subject_Details1.Size = new System.Drawing.Size(1102, 648);
            this.uC_Subject_Details1.TabIndex = 10;
            // 
            // uC_TeacherDetails1
            // 
            this.uC_TeacherDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_TeacherDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.uC_TeacherDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.uC_TeacherDetails1.Location = new System.Drawing.Point(318, 127);
            this.uC_TeacherDetails1.Name = "uC_TeacherDetails1";
            this.uC_TeacherDetails1.Size = new System.Drawing.Size(1102, 648);
            this.uC_TeacherDetails1.TabIndex = 9;
            // 
            // uC_New_Student1
            // 
            this.uC_New_Student1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_New_Student1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.uC_New_Student1.Location = new System.Drawing.Point(318, 127);
            this.uC_New_Student1.Name = "uC_New_Student1";
            this.uC_New_Student1.Size = new System.Drawing.Size(1102, 648);
            this.uC_New_Student1.TabIndex = 8;
            // 
            // uC_Homepanel1
            // 
            this.uC_Homepanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Homepanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.uC_Homepanel1.Location = new System.Drawing.Point(318, 127);
            this.uC_Homepanel1.Name = "uC_Homepanel1";
            this.uC_Homepanel1.Size = new System.Drawing.Size(1102, 648);
            this.uC_Homepanel1.TabIndex = 2;
            this.uC_Homepanel1.Load += new System.EventHandler(this.uC_Homepanel1_Load);
            // 
            // uC_Student_Details1
            // 
            this.uC_Student_Details1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Student_Details1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.uC_Student_Details1.Location = new System.Drawing.Point(318, 127);
            this.uC_Student_Details1.Name = "uC_Student_Details1";
            this.uC_Student_Details1.Size = new System.Drawing.Size(1102, 648);
            this.uC_Student_Details1.TabIndex = 1;
            this.uC_Student_Details1.Load += new System.EventHandler(this.uC_Student_Details1_Load);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 0;
            this.guna2Elipse3.TargetControl = this.uC_Student_Details1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 0;
            this.guna2Elipse4.TargetControl = this.uC_Homepanel1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.uC_New_Student1;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 0;
            this.guna2Elipse5.TargetControl = this.uC_TeacherDetails1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1420, 775);
            this.Controls.Add(this.uC_Subject_Details1);
            this.Controls.Add(this.uC_TeacherDetails1);
            this.Controls.Add(this.uC_New_Student1);
            this.Controls.Add(this.uC_Homepanel1);
            this.Controls.Add(this.uC_Student_Details1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button H_Maximize;
        private System.Windows.Forms.Button H_close;
        private System.Windows.Forms.Button H_Minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addstudents;
        private System.Windows.Forms.Button Teacherdetails;
        private System.Windows.Forms.Button Studentdetails;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Subjectdetails;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UserControls.UC_Student_Details uC_Student_Details1;
        private UserControls.UC_Homepanel uC_Homepanel1;
        private UserControls.UC_New_Student uC_New_Student1;
        private Guna.UI2.WinForms.Guna2ImageButton Homebutton;
        private UserControls.UC_TeacherDetails uC_TeacherDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private UserControls.UC_Subject_Details uC_Subject_Details1;
    }
}