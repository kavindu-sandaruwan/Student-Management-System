using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management_system.UserControls
{
    public partial class UC_TeacherDetails : UserControl
    {
        public UC_TeacherDetails()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_TeacherDetails_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "SELECT TeacherID FROM TeacherDetails";
            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    LASTTID.Text = dr.GetValue(0).ToString();
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            TID.Clear();
            Teachername.Clear();
            TMobilenumber.Clear();
            TSub.ResetText();
            TIDsrch.Clear();
            TeacherDataset.ClearSelection();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tsearch_Click(object sender, EventArgs e)
        {
            string TID = TIDsrch.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry2 = "SELECT * FROM TeacherDetails WHERE TeacherID=('" + TID + "')";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry2, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "TeacherDetails");
                TeacherDataset.DataSource = ds.Tables["TeacherDetails"];
            }
            catch
            {
                MessageBox.Show("Error occrured");
            }
            finally
            {
                con.Close();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            if (TID.Text != "" && Teachername.Text != "" && TMobilenumber.Text != "" && TSub.Text != "")
            {
                int ID = int.Parse(TID.Text);
                string name = Teachername.Text;
                int mobilenum = int.Parse(TMobilenumber.Text);
                string sub = TSub.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry3 = "INSERT INTO TeacherDetails VALUES('" + ID + "', '" + name + "', '" + mobilenum + "', '" + sub + "')";

                SqlCommand cmd = new SqlCommand(qry3, con);


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
            {
                MessageBox.Show("Fill all the Fields");
            }
        }

        private void S_ALLrec_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry5 = "SELECT * FROM TeacherDetails";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry5, constring);
                DataSet ds = new DataSet();
                da.Fill(ds, "TeacherDetails");
                TeacherDataset.DataSource = ds.Tables["TeacherDetails"];
            }
            catch
            {
                MessageBox.Show("Error occrured");
            }
            finally
            {
                constring.Close();
            }
        }
    }
}
