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
using System.IO;
namespace db_project
{
    public partial class NORMALROOM : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8PEOT4L\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");

        public NORMALROOM()
        {
            InitializeComponent();
            displaydata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void displaydata()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  RESERVATIONS ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand(@"select count(*) from reservations where cnic='" + textBox6.Text + "'",con);
                int j;
                j = Convert.ToInt32(cmd1.ExecuteScalar()); // will give count of duplicate data

                if (j != 0)
                {
                    MessageBox.Show("THE RECORD CANNOT BE ENTERED AS CNIC ALREADY EXITS ! ");
                    this.Hide();
                }

                con.Close();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[RESERVATIONS]
           ([NAME]
           ,[CNIC]
           ,[PHONE NUMBER]
           ,[NUMBER OF PEOPLE]
           ,[ADDRESS]
           ,[AGE]
           ,[RESERVATION PERIOD])
     VALUES
           ('" + textBox1.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                MessageBox.Show("successful ! ");

            }
            catch (SqlException ex)
            {
               
            }
          
            con.Close();

            displaydata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainmenu obj = new mainmenu();
            obj.ShowDialog();
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
