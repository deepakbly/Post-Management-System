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
using System.Threading;

namespace PostManagement1
{
    public partial class LogInfrom : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnect"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string AType = "";
        Thread th;
        public LogInfrom()
        {
            Thread t = new Thread(new ThreadStart(splashstart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void splashstart()
        {
            Application.Run(new SplashScreen());
        }
        private void Opennewform(object obj)
        {
            Application.Run(new MDI());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtuserid.Text))
                {
                    throw new Exception("User Name or Password Field is blank !");
                }
                if (rdoAdmini.Checked)
                {
                    AType = rdoAdmini.Text;
                }
                else
                {
                    AType = radioButton2.Text;
                }
                if (con.State == ConnectionState.Closed)
                { con.Open(); }
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserPost1 WHERE UserID='" + txtuserid.Text + "' AND Password='" + txtpassword.Text + "'AND Department='" + comboDepartment.Text + "'AND Atype='" + AType + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Close();
                    th = new Thread(Opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    con.Close();
                    throw new Exception("Error! Invalid Username or Password Selected Account Type is not Correct"); 
                }
              }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
               txtuserid.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
