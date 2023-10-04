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
    public partial class LogInPost : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);
        public LogInPost()
        {
            InitializeComponent();
        }
        DataTable dt=new System.Data.DataTable();
        private void LogInPost_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clear()
        {
              txtUserName.Text="";
              txtConfirmpassword.Text = "";
              comboUserType.Text = "";
            comboDesignation.Text="";
           comboDepartment.Text="";
            txtContectnu.Text="";
            txtUserID.Text="";
            txtPassword.Text = ""; 
          }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {

                if (txtUserID.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Please! Fill Empty Field");
                }
               if (txtUserID.Text == "")
                {
                    MessageBox.Show("Please! Enter E-MailID");
                }
                else
                {

                    
                    SqlCommand cmd1 = new SqlCommand("select *from UserPost1 where UserId='" +txtUserID.Text+ "'", con);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                    adp.Fill(dt);
                    int i = dt.Rows.Count;
                    if (i > 0)
                    {
                        MessageBox.Show("This E-MailID" + txtUserID.Text + "Already Exists");

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec InsertPost '" + txtUserName.Text + "','" + comboUserType.SelectedItem + "','" + comboDesignation.SelectedItem + "','" + comboDepartment.SelectedItem + "','" + txtContectnu.Text + "','" + txtUserID.Text + "','" + txtPassword.Text + "','" + txtPassword.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Welcome To Your Account Successufully Registred ");
                        clear();
                        con.Close();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
