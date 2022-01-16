using System;
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
    public partial class checkkout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8PEOT4L\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

        public checkkout()
        {
            InitializeComponent();
        }
        public void displaydata1()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  reservations ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        public void displaydata2()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  luxury ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            con.Close();

        }

        public void displaydata3()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  cafe ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            con.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            displaydata1();

            displaydata2();
            displaydata3();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu OBJ = new mainmenu();
            OBJ.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp;
            temp = Convert.ToInt64(textBox1.Text);
            con.Open();
            SqlCommand deletedata = new SqlCommand(@"delete from reservations where cnic='" + temp + "'",con);
            deletedata.ExecuteNonQuery();
            con.Close();


            con.Open();
            temp = Convert.ToInt64(textBox1.Text);

            SqlCommand deletedata2 = new SqlCommand(@"delete from cafe where cnic='" + temp + "'", con);
            deletedata2.ExecuteNonQuery();
            con.Close();

            temp = Convert.ToInt64(textBox1.Text);

            con.Open();
            SqlCommand deletedata1 = new SqlCommand(@"delete from luxury where cnic='" + temp + "'", con);
            deletedata1.ExecuteNonQuery();
            con.Close();
     

           

            displaydata1();
            displaydata2();
            displaydata3();
        }
    }
}
