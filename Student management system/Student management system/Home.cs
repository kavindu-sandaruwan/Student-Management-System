using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management_system
{
    public partial class Home : Form
    {
        bool mousedown;
        private Point offset;

        public Home()
        {
            InitializeComponent();
            uC_Homepanel1.Visible = true;
            uC_New_Student1.Visible = false;
            uC_Student_Details1.Visible = false;
            uC_TeacherDetails1.Visible = false;
            uC_Subject_Details1.Visible = false;
        }

        private void F_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void H_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_TeacherDetails1.Visible = true;
            uC_TeacherDetails1.BringToFront();
        }

        private void H_MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }

        private void H_MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location = new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void H_MouseUp_Event(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();
            firstPage.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void Addstudents_Click(object sender, EventArgs e)
        {
            uC_New_Student1.Visible = true;
            uC_New_Student1.BringToFront();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_New_Student1_Load(object sender, EventArgs e)
        {

        }

        private void Studentdetails_Click(object sender, EventArgs e)
        {
            uC_Student_Details1.Visible = true;
            uC_Student_Details1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void uC_Homepanel1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Student_Details1_Load(object sender, EventArgs e)
        {

        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            uC_Homepanel1.Visible = true;
            uC_Homepanel1.BringToFront();
        }

        private void Addstudents_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Subjectdetails_Click(object sender, EventArgs e)
        {
            uC_Subject_Details1.Visible=true;
            uC_Subject_Details1.BringToFront();
        }
    }
}
