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
    public partial class UC_Subject_Details : UserControl
    {
        public UC_Subject_Details()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            S_SubID.Clear();
            ENG.Checked = false;
            Maths.Checked = false;
            Sci.Checked = false;
            Com.Checked = false;
            ICT.Checked = false;
            Subsearch.Clear();
        }

        private void TIDsrch_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SubALLRECbtn_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry5 = "SELECT * FROM SubjectDetails";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry5, constring);
                DataSet ds = new DataSet();
                da.Fill(ds, "SubjectDetails");
                SubjectDataset.DataSource = ds.Tables["SubjectDetails"];
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
