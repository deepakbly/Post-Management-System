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
    public partial class frmRecords : Form
    {
        BindingList<Product> lProd = new BindingList<Product>();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnect"].ConnectionString);
        public frmRecords()
        {
            InitializeComponent();
           
        }

        private void BindData()
        {
            throw new NotImplementedException();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = true;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2Collapsed = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            if (btnSave.ToString() == "Save")
            {
            }
            else
            {
            if (txtletterno.Text == "")
            {
                MessageBox.Show("Please! Fill Empty Fields...");
                txtletterno.Focus();
            }

                DataTable dt = new DataTable();
                SqlCommand cmd1 = new SqlCommand("select *from AddNewDetails where LetterNo='" + txtletterno.Text + "'", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd1);
                adp.Fill(dt);
                int i = dt.Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("LetterNo"  + txtletterno.Text + " already Exists");
                    dt.Clear();
                    
                }
            

                    if (txtUserwork.Text == "" && comboReceivedform.Text == "")
                    {
                        MessageBox.Show("Please! Fill Empty Fields...");
                        txtUserwork.Focus();
                    }
                    else
                    {
                        string date = (dateEntry.Value.ToString("yyyy-MM-dd hh:mm:ss"));
                        string date1 = dateLetter.Value.ToString("yyyy-MM-dd hh:mm:ss");
                        string date2 = dateDue.Value.ToString("yyyy-MM-dd hh:mm:ss");
                        string date3 = dateDone.Value.ToString("yyyy-MM-dd hh:mm:ss");
                        SqlCommand cmd2 = new SqlCommand(" exec Post '" +date+ "','" + comboReceivedform.SelectedItem + "','" + txtletterno.Text + "','" + date1 + "','" + comboreceivedMode.SelectedItem + "','" + comboSubject.SelectedItem + "','" + txtAttachement.Text + "','" + comboAssigntou.SelectedItem + "','" + txtUserwork.Text + "','" + txtDirection.Text + "','" + date2 + "','" + txtWorkdone.Text + "','" + date3+ "'", con);
                        cmd2.ExecuteNonQuery();
                        display();
                        con.Close();
                        MessageBox.Show("Data has been Saved Successufully.");
                        clean();

                    }

                
            }
        }
        
      
        

        void clean()
        {
            txtSrNo.Text = "";
            dateEntry.Text = "";
            comboReceivedform.Text = "";
            comboreceivedMode.Text = "";
            txtletterno.Text = "";
            dateLetter.Text = "";
            comboSubject.Text = "";
            txtAttachement.Text = "";
            comboAssigntou.Text = "";
            txtUserwork.Text = "";
            txtDirection.Text = "";
            dateDue.Text = "";
            txtWorkdone.Text = "";
            dateDone.Text = "";
        }


        private void btnSerach_Click(object sender, EventArgs e)
        {
                DataTable dt = new DataTable();            
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter("select *from AddNewDetails Where EntryDate between '" + dateFrom.Value.ToString("yyyy-MM-dd hh:mm:ss") + "' and'" + dateTo1.Value.ToString("yyyy-MM-dd hh:mm:ss") + "'", con);
                da.Fill(dt);
                dgvFilterData.DataSource = dt;
                         
        }

        private void frmRecords_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(" exec PostUpdate  '" +txtSrNo.Text+ "','" + dateEntry.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" + comboReceivedform.SelectedItem + "','" + txtletterno.Text + "','" + dateLetter.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" + comboreceivedMode.SelectedItem + "','" + comboSubject.SelectedItem + "','" + txtAttachement.Text + "','" + comboAssigntou.SelectedItem + "','" + txtUserwork.Text + "','" + txtDirection.Text + "','" + dateDue.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" + txtWorkdone.Text + "','" + dateDone.Value.ToString("yyyy-MM-dd hh:mm:ss") + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show(" Successufully Updated Data");
                clean();
            }
        }
        void display()
        {

            SqlDataAdapter adpt = new SqlDataAdapter("select * from AddNewDetails", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvFilterData.DataSource = dt;
        }


       // private void btndelete_Click(object sender, EventArgs e)
       // {
            //if (con.State == System.Data.ConnectionState.Closed)
            //{
            //    con.Open();
            //}
            //if (string.IsNullOrEmpty(txtserialno.Text))
            //{
            //    MessageBox.Show("SerialNu Is Empty", "Please! Select Serial Nu.");
            //}
            //else
            //{
            //    SqlCommand cmd = new SqlCommand(" exec PostDelete '" + txtserialno.Text + "'", con);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show(" Successufully Deleted Data");
            //    clean();
            //}
            
       // }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSrNo.Text = "";
            dateEntry.Text = "";
            comboreceivedMode.Text = "";
            comboReceivedform.Text = "";
            txtletterno.Text = "";
            dateLetter.Text = "";
            comboSubject.Text = "";
            txtAttachement.Text = "";
            comboAssigntou.Text = "";
            txtUserwork.Text = "";
            txtDirection.Text = "";
            dateDue.Text = "";
            txtWorkdone.Text = "";
            dateDone.Text = "";
            dgvFilterData.DataSource = "";
        }



        public string LetterNo { get; set; }

        private void btnView_Click(object sender, EventArgs e)
        {
            display();
        }

        private void comboSearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void Search2_Click(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            if (string.IsNullOrEmpty(txtSrNo.Text))
            {
                MessageBox.Show("Field is blank");
            
            //    SqlDataAdapter Sda = new SqlDataAdapter("SELECT *FROM AddNewDetails Where  Like '" + txtSrNo.Text.ToString() + "'", con);
            //    DataTable dt = new DataTable();
            //    Sda.Fill(dt);
            //    dgvFilterData.DataSource = dt;
            //}
            //else if (comboSearchby.Text == "ReceivedMode")
            //{
            //    SqlDataAdapter Sda = new SqlDataAdapter("SELECT *FROM AddNewDetails Where SrNo Like '" + txtSrNo.Text + "'", con);
            //    DataTable dt = new DataTable();
            //    Sda.Fill(dt);
            //    dgvFilterData.DataSource = dt;
            //}
            //else if (comboSearchby.Text == "LetterNo")
            //{
            //    SqlDataAdapter Sda = new SqlDataAdapter("SELECT *FROM AddNewDetails Where SrNo Like '" + txtSrNo.Text + "'", con);
            //    DataTable dt = new DataTable();
            //    Sda.Fill(dt);
            //    dgvFilterData.DataSource = dt;
            //}
            //else if (comboSearchby.Text == "LetterDate")
            //{
            //    SqlDataAdapter Sda = new SqlDataAdapter("SELECT *FROM AddNewDetails Where LeterDate Like '" + txtSrNo.Text.ToString() + "'", con);
            //    DataTable dt = new DataTable();
            //    Sda.Fill(dt);
            //    dgvFilterData.DataSource = dt;
            //}
            //else if (comboSearchby.Text == "Subject")
            //{
            //    SqlDataAdapter Sda = new SqlDataAdapter("SELECT *FROM AddNewDetails Where SrNo Like '" + txtSrNo.Text + "'", con);
            //    DataTable dt = new DataTable();
            //    Sda.Fill(dt);
            //    dgvFilterData.DataSource = dt;
            }
           else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter Sda = new SqlDataAdapter("select *from AddNewDetails where SerialNo = '" + txtSrNo.Text + "'", con);
               // cmd.ExecuteNonQuery();
                Sda.Fill(dt);
               dgvFilterData.DataSource = dt;

            }
            con.Close();

        }


      DataTable dt=new DataTable();

      private void dgvFilterData_CellClick(object sender, DataGridViewCellEventArgs e)
      {
        
          if (dgvFilterData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null)
          {

              dgvFilterData.CurrentRow.Selected = true;
              txtSerialNo.Text = dgvFilterData.Rows[e.RowIndex].Cells["SerialNo"].FormattedValue.ToString();
              dateEntry.Text = dgvFilterData.Rows[e.RowIndex].Cells["EntryDate"].FormattedValue.ToString();
              comboReceivedform.Text = dgvFilterData.Rows[e.RowIndex].Cells["ReceivedFrom"].FormattedValue.ToString();
              txtletterno.Text = dgvFilterData.Rows[e.RowIndex].Cells["LetterNo"].FormattedValue.ToString();
              dateLetter.Text = dgvFilterData.Rows[e.RowIndex].Cells["LetterDate"].FormattedValue.ToString();
              comboreceivedMode.Text = dgvFilterData.Rows[e.RowIndex].Cells["ReceivingMode"].FormattedValue.ToString();
              txtAttachement.Text = dgvFilterData.Rows[e.RowIndex].Cells["Attachement"].FormattedValue.ToString();
              comboAssigntou.Text = dgvFilterData.Rows[e.RowIndex].Cells["AssignToUser"].FormattedValue.ToString();
              txtDirection.Text = dgvFilterData.Rows[e.RowIndex].Cells["Directions"].FormattedValue.ToString();
              dateDue.Text = dgvFilterData.Rows[e.RowIndex].Cells["DueDate"].FormattedValue.ToString();
              txtWorkdone.Text = dgvFilterData.Rows[e.RowIndex].Cells["WorkDone"].FormattedValue.ToString();
              txtUserwork.Text= dgvFilterData.Rows[e.RowIndex].Cells["UserWork"].FormattedValue.ToString();
              dateDone.Text = dgvFilterData.Rows[e.RowIndex].Cells["DoneDate"].FormattedValue.ToString();
               
          }


      }
      public class Product{
        public string SerialNo { get; set; }   
        public string EntryDate { get; set; }
        public string ReceivedFrom { get; set; }
        public string LetterNo { get; set; }
        public string LetterDate { get; set; }
        public string ReceivingMode { get; set; }
        public string Subject { get; set; }
        public string Attachement { get; set; }
        public string AssignToUser { get; set; }
        public string UserWork { get; set; }
        public string Directions { get; set; }
        public string DueDate { get; set; }
        public string WorkDone { get; set; }
        public string DoneDate { get; set; }
      
    public Product(string SerialNo,string ReceivedFrom,string LetterNo,string ReceivingMode,string Subject, string Attachement,string AssignToUser,string WorkDone )
    {   
        this.SerialNo = SerialNo;
        this.ReceivedFrom=ReceivedFrom;
        this.LetterNo = LetterNo;
        this.ReceivingMode=ReceivingMode;
        this.Subject=Subject;
        this. Attachement= Attachement;
        this.AssignToUser=AssignToUser;
        this.WorkDone=WorkDone;
    }
    }  

      private void dgvFilterData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
      {
          var deleteButton = new DataGridViewButtonColumn();

         // deleteButton.Text = "Delete";
        
          ////If this is header row or new row, do nothing
          //if (e.RowIndex < 0 || e.RowIndex == this.dgvFilterData.NewRowIndex)
          //    return;

          //If formatting your desired column, set the value
          if (dgvFilterData.Columns[e.ColumnIndex].Name=="Delete")
          {
             
              e.Value = "Delete";
          }
          
      }

       

    }
}
