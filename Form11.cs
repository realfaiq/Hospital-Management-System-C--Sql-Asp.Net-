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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Labortory set  P_Id=@P_Id, D_Id=@D_Id, Date=@Date, Amount=@Amount where Lab_Id=@Lab_Id", conn);
            cmd.Parameters.AddWithValue("@Lab_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@P_Id", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@D_Id", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Date", textBox4.Text);
            cmd.Parameters.AddWithValue("@Amount", textBox5.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Updated");
        }
    }
}
