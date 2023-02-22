namespace Student_management_system.UserControls
{
    partial class UC_TeacherDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TeacherDetails));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Teachername = new Guna.UI2.WinForms.Guna2TextBox();
            this.TMobilenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TSub = new System.Windows.Forms.DomainUpDown();
            this.LASTTID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TeacherDataset = new System.Windows.Forms.DataGridView();
            this.operaDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.operaDBDataSet = new Student_management_system.OperaDBDataSet();
            this.opera_DBDataSet = new Student_management_system.Opera_DBDataSet();
            this.operaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.TIDsrch = new Guna.UI2.WinForms.Guna2TextBox();
            this.TIDsearch = new System.Windows.Forms.Label();
            this.Tsearch = new System.Windows.Forms.Button();
            this.S_ALLrec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opera_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(72, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Teacher\'s Name";
            // 
            // Teachername
            // 
            this.Teachername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Teachername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Teachername.DefaultText = "";
            this.Teachername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Teachername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Teachername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Teachername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Teachername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Teachername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Teachername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Teachername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Teachername.Location = new System.Drawing.Point(76, 240);
            this.Teachername.Name = "Teachername";
            this.Teachername.PasswordChar = '\0';
            this.Teachername.PlaceholderText = "";
            this.Teachername.SelectedText = "";
            this.Teachername.Size = new System.Drawing.Size(256, 33);
            this.Teachername.TabIndex = 17;
            // 
            // TMobilenumber
            // 
            this.TMobilenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TMobilenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TMobilenumber.DefaultText = "";
            this.TMobilenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TMobilenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TMobilenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TMobilenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TMobilenumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TMobilenumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TMobilenumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TMobilenumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TMobilenumber.Location = new System.Drawing.Point(76, 356);
            this.TMobilenumber.Margin = new System.Windows.Forms.Padding(5);
            this.TMobilenumber.Name = "TMobilenumber";
            this.TMobilenumber.PasswordChar = '\0';
            this.TMobilenumber.PlaceholderText = "";
            this.TMobilenumber.SelectedText = "";
            this.TMobilenumber.Size = new System.Drawing.Size(256, 33);
            this.TMobilenumber.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(72, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mobile Number";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(72, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Subject";
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 0;
            this.guna2Elipse5.TargetControl = this;
            // 
            // TSub
            // 
            this.TSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSub.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSub.Items.Add("English");
            this.TSub.Items.Add("Maths");
            this.TSub.Items.Add("Science");
            this.TSub.Items.Add("Commerce");
            this.TSub.Items.Add("ICT");
            this.TSub.Location = new System.Drawing.Point(76, 457);
            this.TSub.Name = "TSub";
            this.TSub.ReadOnly = true;
            this.TSub.Size = new System.Drawing.Size(256, 31);
            this.TSub.TabIndex = 22;
            this.TSub.Text = "Select";
            this.TSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LASTTID
            // 
            this.LASTTID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LASTTID.AutoSize = true;
            this.LASTTID.BackColor = System.Drawing.Color.Transparent;
            this.LASTTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LASTTID.ForeColor = System.Drawing.Color.GhostWhite;
            this.LASTTID.Location = new System.Drawing.Point(274, 98);
            this.LASTTID.Name = "LASTTID";
            this.LASTTID.Size = new System.Drawing.Size(37, 13);
            this.LASTTID.TabIndex = 41;
            this.LASTTID.Text = "..........";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.GhostWhite;
            this.label14.Location = new System.Drawing.Point(182, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Last Teacher\'s ID =";
            // 
            // TID
            // 
            this.TID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TID.DefaultText = "";
            this.TID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TID.Location = new System.Drawing.Point(76, 137);
            this.TID.Name = "TID";
            this.TID.PasswordChar = '\0';
            this.TID.PlaceholderText = "";
            this.TID.SelectedText = "";
            this.TID.Size = new System.Drawing.Size(256, 33);
            this.TID.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.GhostWhite;
            this.label10.Location = new System.Drawing.Point(72, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Teacher ID";
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel.BackColor = System.Drawing.Color.HotPink;
            this.Cancel.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancel.Location = new System.Drawing.Point(795, 523);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(204, 51);
            this.Cancel.TabIndex = 43;
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
            this.Submit.Location = new System.Drawing.Point(493, 523);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(204, 51);
            this.Submit.TabIndex = 42;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(76, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 31);
            this.label7.TabIndex = 44;
            this.label7.Text = "New Teacher Details";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TeacherDataset
            // 
            this.TeacherDataset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeacherDataset.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TeacherDataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TeacherDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherDataset.Location = new System.Drawing.Point(528, 210);
            this.TeacherDataset.Name = "TeacherDataset";
            this.TeacherDataset.Size = new System.Drawing.Size(441, 278);
            this.TeacherDataset.TabIndex = 7;
            this.TeacherDataset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // operaDBDataSetBindingSource1
            // 
            this.operaDBDataSetBindingSource1.DataSource = this.operaDBDataSet;
            this.operaDBDataSetBindingSource1.Position = 0;
            // 
            // operaDBDataSet
            // 
            this.operaDBDataSet.DataSetName = "OperaDBDataSet";
            this.operaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opera_DBDataSet
            // 
            this.opera_DBDataSet.DataSetName = "Opera_DBDataSet";
            this.opera_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operaDBDataSetBindingSource
            // 
            this.operaDBDataSetBindingSource.DataSource = this.opera_DBDataSet;
            this.operaDBDataSetBindingSource.Position = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GhostWhite;
            this.label4.Location = new System.Drawing.Point(430, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 31);
            this.label4.TabIndex = 46;
            this.label4.Text = "Teacher Details";
            // 
            // TIDsrch
            // 
            this.TIDsrch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TIDsrch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TIDsrch.DefaultText = "";
            this.TIDsrch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TIDsrch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TIDsrch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TIDsrch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TIDsrch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TIDsrch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TIDsrch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TIDsrch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TIDsrch.Location = new System.Drawing.Point(558, 101);
            this.TIDsrch.Name = "TIDsrch";
            this.TIDsrch.PasswordChar = '\0';
            this.TIDsrch.PlaceholderText = "";
            this.TIDsrch.SelectedText = "";
            this.TIDsrch.Size = new System.Drawing.Size(329, 33);
            this.TIDsrch.TabIndex = 48;
            this.TIDsrch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // TIDsearch
            // 
            this.TIDsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TIDsearch.AutoSize = true;
            this.TIDsearch.BackColor = System.Drawing.Color.Transparent;
            this.TIDsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIDsearch.ForeColor = System.Drawing.Color.GhostWhite;
            this.TIDsearch.Location = new System.Drawing.Point(449, 105);
            this.TIDsearch.Name = "TIDsearch";
            this.TIDsearch.Size = new System.Drawing.Size(103, 24);
            this.TIDsearch.TabIndex = 47;
            this.TIDsearch.Text = "Teacher ID";
            // 
            // Tsearch
            // 
            this.Tsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tsearch.BackColor = System.Drawing.Color.Gold;
            this.Tsearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tsearch.Location = new System.Drawing.Point(893, 101);
            this.Tsearch.Name = "Tsearch";
            this.Tsearch.Size = new System.Drawing.Size(145, 33);
            this.Tsearch.TabIndex = 49;
            this.Tsearch.Text = "Search";
            this.Tsearch.UseVisualStyleBackColor = false;
            this.Tsearch.Click += new System.EventHandler(this.Tsearch_Click);
            // 
            // S_ALLrec
            // 
            this.S_ALLrec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.S_ALLrec.BackColor = System.Drawing.Color.Gold;
            this.S_ALLrec.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ALLrec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.S_ALLrec.Location = new System.Drawing.Point(893, 154);
            this.S_ALLrec.Name = "S_ALLrec";
            this.S_ALLrec.Size = new System.Drawing.Size(145, 39);
            this.S_ALLrec.TabIndex = 51;
            this.S_ALLrec.Text = "All Records";
            this.S_ALLrec.UseVisualStyleBackColor = false;
            this.S_ALLrec.Click += new System.EventHandler(this.S_ALLrec_Click);
            // 
            // UC_TeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.S_ALLrec);
            this.Controls.Add(this.Tsearch);
            this.Controls.Add(this.TIDsrch);
            this.Controls.Add(this.TIDsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TeacherDataset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LASTTID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TMobilenumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Teachername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "UC_TeacherDetails";
            this.Size = new System.Drawing.Size(1102, 648);
            this.Load += new System.EventHandler(this.UC_TeacherDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opera_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Teachername;
        private Guna.UI2.WinForms.Guna2TextBox TMobilenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private System.Windows.Forms.DomainUpDown TSub;
        private System.Windows.Forms.Label LASTTID;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox TID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView TeacherDataset;
        private System.Windows.Forms.BindingSource operaDBDataSetBindingSource;
        private Opera_DBDataSet opera_DBDataSet;
        private Guna.UI2.WinForms.Guna2TextBox TIDsrch;
        private System.Windows.Forms.Label TIDsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Tsearch;
        private System.Windows.Forms.BindingSource operaDBDataSetBindingSource1;
        private OperaDBDataSet operaDBDataSet;
        private System.Windows.Forms.Button S_ALLrec;
    }
}
