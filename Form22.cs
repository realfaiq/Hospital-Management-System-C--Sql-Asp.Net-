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

namespace HospitalManagementSystem
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete Bill where Bill_Id=@Bill_Id", conn);
            cmd.Parameters.AddWithValue("@Bill_Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
