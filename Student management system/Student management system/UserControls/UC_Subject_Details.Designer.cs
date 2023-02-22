namespace Student_management_system.UserControls
{
    partial class UC_Subject_Details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Subject_Details));
            this.SubjectDataset = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.S_SubID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubALLRECbtn = new System.Windows.Forms.Button();
            this.Subsearchbtn = new System.Windows.Forms.Button();
            this.Subsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.TIDsearch = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ENG = new System.Windows.Forms.CheckBox();
            this.Maths = new System.Windows.Forms.CheckBox();
            this.Com = new System.Windows.Forms.CheckBox();
            this.Sci = new System.Windows.Forms.CheckBox();
            this.ICT = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectDataset
            // 
            this.SubjectDataset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubjectDataset.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SubjectDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubjectDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataset.Location = new System.Drawing.Point(493, 211);
            this.SubjectDataset.Name = "SubjectDataset";
            this.SubjectDataset.Size = new System.Drawing.Size(506, 278);
            this.SubjectDataset.TabIndex = 17;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel.BackColor = System.Drawing.Color.HotPink;
            this.Cancel.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel.Location = new System.Drawing.Point(830, 523);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(204, 51);
            this.Cancel.TabIndex = 45;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Submit
            // 
            this.Submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Submit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Submit.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Location = new System.Drawing.Point(72, 523);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(204, 51);
            this.Submit.TabIndex = 44;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            // 
            // S_SubID
            // 
            this.S_SubID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.S_SubID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.S_SubID.DefaultText = "";
            this.S_SubID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.S_SubID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.S_SubID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.S_SubID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.S_SubID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.S_SubID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.S_SubID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.S_SubID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.S_SubID.Location = new System.Drawing.Point(72, 199);
            this.S_SubID.Name = "S_SubID";
            this.S_SubID.PasswordChar = '\0';
            this.S_SubID.PlaceholderText = "";
            this.S_SubID.SelectedText = "";
            this.S_SubID.Size = new System.Drawing.Size(256, 33);
            this.S_SubID.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.GhostWhite;
            this.label10.Location = new System.Drawing.Point(68, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 24);
            this.label10.TabIndex = 48;
            this.label10.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(68, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Subject";
            // 
            // SubALLRECbtn
            // 
            this.SubALLRECbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubALLRECbtn.BackColor = System.Drawing.Color.Gold;
            this.SubALLRECbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubALLRECbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubALLRECbtn.Location = new System.Drawing.Point(889, 147);
            this.SubALLRECbtn.Name = "SubALLRECbtn";
            this.SubALLRECbtn.Size = new System.Drawing.Size(145, 39);
            this.SubALLRECbtn.TabIndex = 59;
            this.SubALLRECbtn.Text = "All Records";
            this.SubALLRECbtn.UseVisualStyleBackColor = false;
            this.SubALLRECbtn.Click += new System.EventHandler(this.SubALLRECbtn_Click);
            // 
            // Subsearchbtn
            // 
            this.Subsearchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Subsearchbtn.BackColor = System.Drawing.Color.Gold;
            this.Subsearchbtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subsearchbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Subsearchbtn.Location = new System.Drawing.Point(889, 94);
            this.Subsearchbtn.Name = "Subsearchbtn";
            this.Subsearchbtn.Size = new System.Drawing.Size(145, 33);
            this.Subsearchbtn.TabIndex = 58;
            this.Subsearchbtn.Text = "Search";
            this.Subsearchbtn.UseVisualStyleBackColor = false;
            // 
            // Subsearch
            // 
            this.Subsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Subsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Subsearch.DefaultText = "";
            this.Subsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Subsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Subsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Subsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Subsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Subsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Subsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Subsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Subsearch.Location = new System.Drawing.Point(554, 94);
            this.Subsearch.Name = "Subsearch";
            this.Subsearch.PasswordChar = '\0';
            this.Subsearch.PlaceholderText = "";
            this.Subsearch.SelectedText = "";
            this.Subsearch.Size = new System.Drawing.Size(329, 33);
            this.Subsearch.TabIndex = 57;
            this.Subsearch.TextChanged += new System.EventHandler(this.TIDsrch_TextChanged);
            // 
            // TIDsearch
            // 
            this.TIDsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TIDsearch.AutoSize = true;
            this.TIDsearch.BackColor = System.Drawing.Color.Transparent;
            this.TIDsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIDsearch.ForeColor = System.Drawing.Color.GhostWhite;
            this.TIDsearch.Location = new System.Drawing.Point(445, 98);
            this.TIDsearch.Name = "TIDsearch";
            this.TIDsearch.Size = new System.Drawing.Size(96, 24);
            this.TIDsearch.TabIndex = 56;
            this.TIDsearch.Text = "Student ID";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(334, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(768, 648);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(72, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 27);
            this.label7.TabIndex = 60;
            this.label7.Text = "Add Student\'s Subject Details";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ENG
            // 
            this.ENG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ENG.AutoSize = true;
            this.ENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENG.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.ENG.Location = new System.Drawing.Point(89, 297);
            this.ENG.Name = "ENG";
            this.ENG.Size = new System.Drawing.Size(87, 24);
            this.ENG.TabIndex = 61;
            this.ENG.Text = "English";
            this.ENG.UseVisualStyleBackColor = true;
            this.ENG.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Maths
            // 
            this.Maths.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Maths.AutoSize = true;
            this.Maths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maths.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Maths.Location = new System.Drawing.Point(89, 326);
            this.Maths.Name = "Maths";
            this.Maths.Size = new System.Drawing.Size(77, 24);
            this.Maths.TabIndex = 62;
            this.Maths.Text = "Maths";
            this.Maths.UseVisualStyleBackColor = true;
            // 
            // Com
            // 
            this.Com.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Com.AutoSize = true;
            this.Com.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Com.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Com.Location = new System.Drawing.Point(89, 385);
            this.Com.Name = "Com";
            this.Com.Size = new System.Drawing.Size(113, 24);
            this.Com.TabIndex = 64;
            this.Com.Text = "Commerce";
            this.Com.UseVisualStyleBackColor = true;
            // 
            // Sci
            // 
            this.Sci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sci.AutoSize = true;
            this.Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sci.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Sci.Location = new System.Drawing.Point(89, 356);
            this.Sci.Name = "Sci";
            this.Sci.Size = new System.Drawing.Size(92, 24);
            this.Sci.TabIndex = 63;
            this.Sci.Text = "Science";
            this.Sci.UseVisualStyleBackColor = true;
            // 
            // ICT
            // 
            this.ICT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ICT.AutoSize = true;
            this.ICT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICT.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.ICT.Location = new System.Drawing.Point(89, 415);
            this.ICT.Name = "ICT";
            this.ICT.Size = new System.Drawing.Size(56, 24);
            this.ICT.TabIndex = 65;
            this.ICT.Text = "ICT";
            this.ICT.UseVisualStyleBackColor = true;
            // 
            // UC_Subject_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.ICT);
            this.Controls.Add(this.Com);
            this.Controls.Add(this.Sci);
            this.Controls.Add(this.Maths);
            this.Controls.Add(this.ENG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubALLRECbtn);
            this.Controls.Add(this.Subsearchbtn);
            this.Controls.Add(this.Subsearch);
            this.Controls.Add(this.TIDsearch);
            this.Controls.Add(this.S_SubID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.SubjectDataset);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "UC_Subject_Details";
            this.Size = new System.Drawing.Size(1102, 648);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView SubjectDataset;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Submit;
        private Guna.UI2.WinForms.Guna2TextBox S_SubID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubALLRECbtn;
        private System.Windows.Forms.Button Subsearchbtn;
        private Guna.UI2.WinForms.Guna2TextBox Subsearch;
        private System.Windows.Forms.Label TIDsearch;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ENG;
        private System.Windows.Forms.CheckBox Maths;
        private System.Windows.Forms.CheckBox Com;
        private System.Windows.Forms.CheckBox Sci;
        private System.Windows.Forms.CheckBox ICT;
    }
}
