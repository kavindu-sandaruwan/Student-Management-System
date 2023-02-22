namespace Student_management_system.UserControls
{
    partial class UC_Student_Details
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
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.StudentDataset = new System.Windows.Forms.DataGridView();
            this.S_ALLrec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // StudentDataset
            // 
            this.StudentDataset.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.StudentDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataset.Dock = System.Windows.Forms.DockStyle.Right;
            this.StudentDataset.Location = new System.Drawing.Point(188, 0);
            this.StudentDataset.Name = "StudentDataset";
            this.StudentDataset.Size = new System.Drawing.Size(914, 648);
            this.StudentDataset.TabIndex = 7;
            this.StudentDataset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // S_ALLrec
            // 
            this.S_ALLrec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.S_ALLrec.BackColor = System.Drawing.Color.Gold;
            this.S_ALLrec.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ALLrec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.S_ALLrec.Location = new System.Drawing.Point(22, 200);
            this.S_ALLrec.Name = "S_ALLrec";
            this.S_ALLrec.Size = new System.Drawing.Size(160, 50);
            this.S_ALLrec.TabIndex = 50;
            this.S_ALLrec.Text = "All Records";
            this.S_ALLrec.UseVisualStyleBackColor = false;
            this.S_ALLrec.Click += new System.EventHandler(this.Tsearch_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(22, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 51;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(22, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 52;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // UC_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(36)))), ((int)(((byte)(97)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.S_ALLrec);
            this.Controls.Add(this.StudentDataset);
            this.Name = "UC_Student_Details";
            this.Size = new System.Drawing.Size(1102, 648);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.DataGridView StudentDataset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button S_ALLrec;
    }
}
