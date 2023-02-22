namespace Student_management_system
{
    partial class Sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up));
            this.panel2 = new System.Windows.Forms.Panel();
            this.S_Maximize = new System.Windows.Forms.Button();
            this.S_close = new System.Windows.Forms.Button();
            this.S_Minimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.S_Mobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.S_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.S_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Signup = new System.Windows.Forms.Button();
            this.L_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.S_Maximize);
            this.panel2.Controls.Add(this.S_close);
            this.panel2.Controls.Add(this.S_Minimize);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 30);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.S_MouseDown_Event);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.S_MouseMove_Event);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.S_MouseUp_Event);
            // 
            // S_Maximize
            // 
            this.S_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.S_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.S_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("S_Maximize.Image")));
            this.S_Maximize.Location = new System.Drawing.Point(656, 1);
            this.S_Maximize.Name = "S_Maximize";
            this.S_Maximize.Size = new System.Drawing.Size(26, 26);
            this.S_Maximize.TabIndex = 5;
            this.S_Maximize.UseVisualStyleBackColor = true;
            this.S_Maximize.Click += new System.EventHandler(this.F_Maximize_Click);
            // 
            // S_close
            // 
            this.S_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.S_close.BackColor = System.Drawing.Color.Tomato;
            this.S_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.S_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S_close.Image = ((System.Drawing.Image)(resources.GetObject("S_close.Image")));
            this.S_close.Location = new System.Drawing.Point(686, 1);
            this.S_close.Name = "S_close";
            this.S_close.Size = new System.Drawing.Size(26, 26);
            this.S_close.TabIndex = 2;
            this.S_close.UseVisualStyleBackColor = false;
            this.S_close.Click += new System.EventHandler(this.S_close_Click);
            // 
            // S_Minimize
            // 
            this.S_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.S_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.S_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.S_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("S_Minimize.Image")));
            this.S_Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.S_Minimize.Location = new System.Drawing.Point(624, 1);
            this.S_Minimize.Name = "S_Minimize";
            this.S_Minimize.Size = new System.Drawing.Size(26, 26);
            this.S_Minimize.TabIndex = 3;
            this.S_Minimize.UseVisualStyleBackColor = true;
            this.S_Minimize.Click += new System.EventHandler(this.S_Minimize_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.L_password);
            this.panel1.Controls.Add(this.S_Mobile);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.S_Email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.S_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.F_Signup);
            this.panel1.Location = new System.Drawing.Point(120, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 605);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // S_Mobile
            // 
            this.S_Mobile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.S_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Mobile.Location = new System.Drawing.Point(201, 470);
            this.S_Mobile.Name = "S_Mobile";
            this.S_Mobile.Size = new System.Drawing.Size(224, 29);
            this.S_Mobile.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(33, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mobile Number";
            // 
            // S_Email
            // 
            this.S_Email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.S_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Email.Location = new System.Drawing.Point(201, 417);
            this.S_Email.Name = "S_Email";
            this.S_Email.Size = new System.Drawing.Size(224, 29);
            this.S_Email.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(33, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(33, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirm Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(161, 513);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an acount?Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(33, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // S_username
            // 
            this.S_username.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.S_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.S_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_username.Location = new System.Drawing.Point(201, 254);
            this.S_username.Name = "S_username";
            this.S_username.Size = new System.Drawing.Size(224, 29);
            this.S_username.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
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
            // F_Signup
            // 
            this.F_Signup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.F_Signup.BackColor = System.Drawing.Color.Gold;
            this.F_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.F_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Signup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.F_Signup.Location = new System.Drawing.Point(180, 537);
            this.F_Signup.Name = "F_Signup";
            this.F_Signup.Size = new System.Drawing.Size(102, 35);
            this.F_Signup.TabIndex = 2;
            this.F_Signup.Text = "Sign up";
            this.F_Signup.UseVisualStyleBackColor = false;
            // 
            // L_password
            // 
            this.L_password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.L_password.BorderColor = System.Drawing.Color.Empty;
            this.L_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.L_password.DefaultText = "";
            this.L_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.L_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.L_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.L_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.L_password.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.L_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.L_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.L_password.ForeColor = System.Drawing.Color.Black;
            this.L_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.L_password.Location = new System.Drawing.Point(201, 309);
            this.L_password.Name = "L_password";
            this.L_password.PasswordChar = '*';
            this.L_password.PlaceholderText = "";
            this.L_password.SelectedText = "";
            this.L_password.Size = new System.Drawing.Size(224, 29);
            this.L_password.TabIndex = 10;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Empty;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.InactiveCaption;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(201, 363);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '*';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(224, 29);
            this.guna2TextBox1.TabIndex = 20;
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button S_Maximize;
        private System.Windows.Forms.Button S_close;
        private System.Windows.Forms.Button S_Minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button F_Signup;
        private System.Windows.Forms.TextBox S_Mobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox S_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox S_username;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox L_password;
    }
}