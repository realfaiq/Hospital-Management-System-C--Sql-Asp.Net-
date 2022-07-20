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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Patient set Name=@Name, Age=@Age, Gender=@Gender, Address=@Address, Disease=@Disease, D_Id=@D_Id where P_Id=@P_Id", conn);
            cmd.Parameters.AddWithValue("@P_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Gender", textBox4.Text);
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.Parameters.AddWithValue("@Disease", textBox6.Text);
            cmd.Parameters.AddWithValue("@D_Id", textBox7.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Updated");
        }
    }
}
