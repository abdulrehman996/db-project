﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace db_project
{
    public partial class cafecs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8PEOT4L\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

        public cafecs()
        {
            InitializeComponent();
            displaydata();
        }
        public void displaydata()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  cafe ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        public void displaydata1()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  totalbill ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void cafecs_Load(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


              

                

                try { 
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[cafe]
           ([cnic]
           ,[drinks]
,[drinksbill]

           ,[bbq]
,[bbqbill]
           ,[pastas]
,[pastasbill]          
,[common]
,[commonbill]          
,[pakistani]
,[pakistanbill]           
,[rice]
,[ricebill]           
,[derserts]
,[desertbill]           
,[dq]
           ,[bbqq]
           ,[pastasq]
           ,[coq]
           ,[pakq]
           ,[ricq]
,[desertq])
     VALUES
           ('" + textBox22.Text + "','" + comboBox8.Text + "','"+Convert.ToInt32(comboBox1.Text)*45+"','" + comboBox9.Text + "','" + Convert.ToInt32(comboBox2.Text) * 350 + "','" + comboBox10.Text + "','" + Convert.ToInt32(comboBox3.Text) * 500 + "','" + comboBox11.Text + "','" + Convert.ToInt32(comboBox4.Text) * 423 + "','" + comboBox12.Text + "','" + Convert.ToInt32(comboBox5.Text) * 20 + "','" + comboBox13.Text + "','" + Convert.ToInt32(comboBox6.Text) * 250 + "','" + comboBox14.Text + "','" + Convert.ToInt32(comboBox7.Text) * 150 + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successful ! ");

                }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            con.Close();

            displaydata();
        

            
            con.Close();

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu obj = new mainmenu();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            int h;
            string j;            
            SqlCommand totalbill = new SqlCommand(@"select (drinksbill+bbqbill+commonbill+pakistanbill+desertbill+ricebill+pastasbill) from cafe where cnic='" + textBox22.Text + "'", con);
            h = Convert.ToInt32(totalbill.ExecuteScalar());
            j = Convert.ToString(h);
            con.Close();
            SqlCommand insertnow = new SqlCommand(@"INSERT INTO [dbo].[totalbill]
([cnic],[total])
values ('"+textBox22.Text+"','" + h + "')",con);
            con.Open();
            insertnow.ExecuteNonQuery();

            con.Close();
            
            MessageBox.Show(j);
            displaydata1();
            
        }
    }
}
