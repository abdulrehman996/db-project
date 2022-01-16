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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8PEOT4L\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True");
          SqlCommand cm;
          private void button1_Click(object sender, EventArgs e)
          {
               if (Authenticate())
               {
                    conn.Open();
                    string query = ("Select * from SignUP where Username=@check and Password=@passcheck");
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.Add("@check", SqlDbType.VarChar);
                    cm.Parameters["@check"].Value = textBox1.Text;
                    cm.Parameters.Add("@passcheck", SqlDbType.VarChar);
                    cm.Parameters["@passcheck"].Value = textBox2.Text;
                    SqlDataReader read = cm.ExecuteReader();
                    if (read.HasRows)
                    {
                         mainmenu f1 = new mainmenu();
                         f1.Show();
                         this.Hide();
                         conn.Close();
                         return;
                    }
                    else
                    {
                         MessageBox.Show("User Does Not Exist");
                         conn.Close();
                         return;
                    }
                    conn.Close();
               }
          }
          bool Authenticate()
          {
               if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
               {
                    return false;
               }
               else
                    return true;
          }

          private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

		private void button3_Click(object sender, EventArgs e)
		{
               this.Hide();
               Form3 form3 = new Form3();
               form3.ShowDialog();

		}
	}
}
