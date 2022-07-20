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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete Labortory where Lab_Id=@Lab_Id", conn);
            cmd.Parameters.AddWithValue("@Lab_Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
