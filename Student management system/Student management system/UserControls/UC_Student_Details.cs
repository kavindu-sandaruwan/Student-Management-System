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
    public partial class UC_Student_Details : UserControl
    {
        public UC_Student_Details()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tsearch_Click(object sender, EventArgs e)
        {
            SqlConnection constring = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\OperaDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry4 = "SELECT * FROM NewStudent";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry4, constring);
                DataSet ds = new DataSet();
                da.Fill(ds, "NewStudent");
                StudentDataset.DataSource = ds.Tables["NewStudent"];
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
