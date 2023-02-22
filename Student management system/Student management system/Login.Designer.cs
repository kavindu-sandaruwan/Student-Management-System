namespace Student_management_system
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.L_Maximize = new System.Windows.Forms.Button();
            this.L_close = new System.Windows.Forms.Button();
            this.L_Minimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.L_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.L_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.L_Maximize);
            this.panel2.Controls.Add(this.L_close);
            this.panel2.Controls.Add(this.L_Minimize);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 30);
            this.panel2.TabIndex = 6;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.L_MouseDown_Event);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.L_MouseMove_Event);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.L_MouseUp_Event);
            // 
            // L_Maximize
            // 
            this.L_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.L_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("L_Maximize.Image")));
            this.L_Maximize.Location = new System.Drawing.Point(590, 1);
            this.L_Maximize.Name = "L_Maximize";
            this.L_Maximize.Size = new System.Drawing.Size(26, 26);
            this.L_Maximize.TabIndex = 5;
            this.L_Maximize.UseVisualStyleBackColor = true;
            this.L_Maximize.Click += new System.EventHandler(this.L_Maximize_Click);
            // 
            // L_close
            // 
            this.L_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_close.BackColor = System.Drawing.Color.Tomato;
            this.L_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.L_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_close.Image = ((System.Drawing.Image)(resources.GetObject("L_close.Image")));
            this.L_close.Location = new System.Drawing.Point(620, 1);
            this.L_close.Name = "L_close";
            this.L_close.Size = new System.Drawing.Size(26, 26);
            this.L_close.TabIndex = 2;
            this.L_close.UseVisualStyleBackColor = false;
            this.L_close.Click += new System.EventHandler(this.L_close_Click);
            // 
            // L_Minimize
            // 
            this.L_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.L_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("L_Minimize.Image")));
            this.L_Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.L_Minimize.Location = new System.Drawing.Point(558, 1);
            this.L_Minimize.Name = "L_Minimize";
            this.L_Minimize.Size = new System.Drawing.Size(26, 26);
            this.L_Minimize.TabIndex = 3;
            this.L_Minimize.UseVisualStyleBackColor = true;
            this.L_Minimize.Click += new System.EventHandler(this.L_Minimize_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.L_password);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.L_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.L_Login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 502);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(160, 378);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t have account? Create one";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(63, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // L_username
            // 
            this.L_username.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.L_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_username.Location = new System.Drawing.Point(181, 264);
            this.L_username.Name = "L_username";
            this.L_username.Size = new System.Drawing.Size(224, 29);
            this.L_username.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(63, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 4;
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
            // L_Login
            // 
            this.L_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Login.BackColor = System.Drawing.Color.Gold;
            this.L_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.L_Login.Location = new System.Drawing.Point(181, 409);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(102, 35);
            this.L_Login.TabIndex = 3;
            this.L_Login.Text = "Login";
            this.L_Login.UseVisualStyleBackColor = false;
            this.L_Login.Click += new System.EventHandler(this.L_Login_Click);
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
            this.L_password.Location = new System.Drawing.Point(181, 315);
            this.L_password.Name = "L_password";
            this.L_password.PasswordChar = '*';
            this.L_password.PlaceholderText = "";
            this.L_password.SelectedText = "";
            this.L_password.Size = new System.Drawing.Size(224, 29);
            this.L_password.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button L_Maximize;
        private System.Windows.Forms.Button L_close;
        private System.Windows.Forms.Button L_Minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button L_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox L_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox L_password;
    }
}