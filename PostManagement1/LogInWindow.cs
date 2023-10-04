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
using System.Configuration;


namespace PostManagement1
{
    public partial class LogInWindow : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);
                 public LogInWindow()
        {
            InitializeComponent();
        }

                 DataTable dt = new DataTable();

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            if (rdoAdmin.Enabled == true)
            {
                MessageBox.Show("Please ! Select User Type ?");

            } 
         
               
              else  if (txtUserId.Text == "" && txtPassword.Text == "")
                {

                    MessageBox.Show("Enter E-MailID or Password ?");
                    
                }

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserPost1 WHERE UserID='" + txtUserId.Text + "' AND Password='" + txtPassword.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                        MDI m1 = new MDI();
                        m1.ShowDialog();
                    }
                      
                else
                  {
                    MessageBox.Show("Invalid username or password");
                    con.Close();
                    return;

                 }
            }  
                

    }
}
