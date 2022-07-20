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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Room values (@R_Id, @R_Type, @Status)", conn);
            cmd.Parameters.AddWithValue("@R_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@R_Type", textBox2.Text);
            cmd.Parameters.AddWithValue("@Status", textBox3.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Inserted");
        }
    }
}
