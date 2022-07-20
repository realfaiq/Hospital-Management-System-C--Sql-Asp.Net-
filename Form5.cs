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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into InPatient values (@P_Id, @R_Id, @Date_Of_Adm, @Date_Of_Dis, @Lab_Id)", conn);
            cmd.Parameters.AddWithValue("@P_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@R_Id", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Date_Of_Adm", textBox3.Text);
            cmd.Parameters.AddWithValue("@Date_Of_Dis", textBox4.Text);
            cmd.Parameters.AddWithValue("@Lab_Id", int.Parse(textBox5.Text));
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Inserted");
        }
    }
}
