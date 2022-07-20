﻿using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Bill values (@Bill_Id, @P_Id, @Doctor_Charge, @Room_Charge, @No_Of_Days, @Lab_Charge)", conn);
            cmd.Parameters.AddWithValue("@Bill_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@P_Id", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Doctor_Charge", textBox3.Text);
            cmd.Parameters.AddWithValue("@Room_Charge", textBox4.Text);
            cmd.Parameters.AddWithValue("@No_Of_Days", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("Lab_Charge", textBox6.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Inserted");
        }
    }
}
