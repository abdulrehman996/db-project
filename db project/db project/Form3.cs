using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_project
{
	public partial class Form3 : Form
	{
		public Form3()
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
                    string query1 = "Select*from SignUP where Email=@check and Username = @usercheck";

                    cm = new SqlCommand(query1, conn);
                    cm.Parameters.Add("@check", SqlDbType.VarChar);
                    cm.Parameters["@check"].Value = textBox4.Text;
                    cm.Parameters.Add("@usercheck", SqlDbType.VarChar);
                    cm.Parameters["@usercheck"].Value = textBox2.Text;
                    SqlDataReader sda = cm.ExecuteReader();
                    if (sda.HasRows)
                    {
                         MessageBox.Show("Username Already exist");
                         conn.Close();
                         return;
                    }
                    conn.Close();
                    string query = "Insert into SignUP(Username,Password,Email,Phone,CNIC)values(@Username,@Password,@Email,@Phone,@CNIC)";
                    conn.Open();
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.Add("@Username", SqlDbType.VarChar);
                    cm.Parameters["@Username"].Value = textBox1.Text;
                    cm.Parameters.Add("@Password", SqlDbType.VarChar);
                    cm.Parameters["@Password"].Value = textBox2.Text;
                    cm.Parameters.Add("@Email", SqlDbType.VarChar);
                    cm.Parameters["@Email"].Value = textBox3.Text;
                    cm.Parameters.Add("@Phone", SqlDbType.VarChar);
                    cm.Parameters["@Phone"].Value = textBox4.Text;
                    cm.Parameters.Add("@CNIC", SqlDbType.VarChar);
                    cm.Parameters["@CNIC"].Value = textBox5.Text;
                    MessageBox.Show("Signup Complete");
                    cm.ExecuteNonQuery();
                    conn.Close();
               }
               else
               {
                    MessageBox.Show("Please Fill All The Credentials!");
                    return;
               }
          }
          bool Authenticate()
          {
               if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
               {
                    return false;
               }
               else
                    return true;
          }

		private void button2_Click_1(object sender, EventArgs e)
		{
               this.Hide();
               Form1 form1 = new Form1();
               form1.ShowDialog();
               this.Close();
          }
	}
}
