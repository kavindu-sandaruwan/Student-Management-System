using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_management_system.UserControls
{
    public partial class UC_New_Student : UserControl
    {
        public UC_New_Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SID.Text != "" && Studentname.Text != "" && SAddress.Text != "" && SSchool.Text != "" && S_Email.Text != "" && S_mobileNum.Text != "" && S_Dob.Text != "" && SGender.Text != "" && GName.Text != "" && GMobileNumber.Text != "" && GAddress.Text != "")
            {
                int ID = int.Parse(SID.Text);
                string name = Studentname.Text;
                string Address = SAddress.Text;
                string school = SSchool.Text;
                string Email = S_Email.Text;
                int Mobilenum = int.Parse(S_mobileNum.Text);
                string dob = S_Dob.Text;
                string gender = SGender.Text;
                string Gname = GName.Text;
                int GMobilenum = int.Parse(GMobileNumber.Text);
                string Gaddress = GAddress.Text;


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO NewStudent VALUES('" + ID + "','" + name + "','" + Address + "','" + school + "','" + Email + "','" + Mobilenum + "','" + dob + "','" + gender + "','" + Gname + "','" + GMobilenum + "','" + Gaddress + "')";
                SqlCommand cmd = new SqlCommand(qry, con);


                try
                {

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error Occured" + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

            }
            else
            { MessageBox.Show("Fill all the Fields"); }
        }

        private void UC_New_Student_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry1 = "SELECT ID FROM NewStudent";
            SqlCommand cmd = new SqlCommand(qry1, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    if (dr.GetValue(0) == null)
                    {
                        LASTID.Text = "0";
                    }
                    else
                    {
                        LASTID.Text = dr.GetValue(0).ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Occured" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SID.Clear();
            Studentname.Clear();
            SAddress.Clear();
            SSchool.Clear();
            S_Email.Clear();
            S_Dob.ResetText();
            S_mobileNum.Clear();
            SGender.ResetText();
            GName.Clear();
            GAddress.Clear();
            GMobileNumber.Clear();
        }

        private void LASTID_Click(object sender, EventArgs e)
        {

        }
    }
}
