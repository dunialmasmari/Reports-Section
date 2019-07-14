using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FRM_SenderViewReport : Form
    {
        BL.CLS_Reports r = new BL.CLS_Reports();
        public FRM_SenderViewReport()
        {
            InitializeComponent();
        }
        public string s;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.type == 2)
            {


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_senderReports();

            }
            if (Program.type == 1)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_all();


            }
            if (Program.type == 3)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_Receiverall();
                
            }
           

            
        }

        private void FRM_SenderViewReport_Load(object sender, EventArgs e)
        {
           
           if (Program.type==2)
           {
               
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_senderReports();
               
          }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.type == 2)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_senderReportsAssigned();

            }
            if (Program.type == 1)
            {


                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_assigned();

            }
            if (Program.type == 3)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_ReceiverAssigned();
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.type == 2)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_senderReportsdone();

            }
            if (Program.type == 1)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_done();



            }
            if (Program.type == 3)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_Receiverdone();
            }
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.type == 2)
            {

                dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = r.Get_All_senderReportsnot();
        }

            
            if (Program.type == 1)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_notdone();


            }
            if (Program.type == 3)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_Receivernotdone();
            }
           
}

        private void button6_Click(object sender, EventArgs e)
        {
            if (Program.type == 2)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_senderReportsondoing();
            }


            if (Program.type == 1)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_ondoing();


            }
            if (Program.type == 3)
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_Receiverondoing();
            }

          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Program.type == 2)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_senderReportsSeen();
            }


            if (Program.type == 1)
            {

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = r.Get_All_ReportsSeen();


            }
         
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FRM_SentReportDetails s = new FRM_SentReportDetails();
           
            DataTable Dt = r.Get_All_moredetails(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (Dt.Rows.Count > 0)
            {
                if (Program.type == 1 || Program.type == 2) {
                s.label6.Text = Dt.Rows[0]["sender_Report_ID"].ToString();
                s.label7.Text = Dt.Rows[0]["Department_Name"].ToString();
               s.more.Text= "Report Details about solving";
                s.label8.Text = Dt.Rows[0]["sentDate"].ToString();
                s.label9.Text = Dt.Rows[0]["Title"].ToString();
                s.label10.Text = Dt.Rows[0]["Details"].ToString();
                s.label11.Text = Dt.Rows[0]["status_Name"].ToString();
                s.label13.Text = Dt.Rows[0]["Major_Name"].ToString();
                if (s.label11.Text == "On Doing" ||  s.label11.Text == "Assigned")
                {
                    s.more.Enabled = false;
                   
                }

                if (s.label11.Text == "Seen" )
                {
                    s.label13.Visible = false;
                    s.label16.Visible = false;
                    if (Program.type == 1)
                    {

                        s.more.Text = "Forward to Worker";
                        s.more.Enabled = true;


                    }
                    if (Program.type == 2)
                    {
                        s.more.Enabled = false;
                    }
                }
                if (s.label11.Text == "No status")
                {
                    s.label13.Visible = false;
                    s.label16.Visible = false;
                    if (Program.type == 1)
                    {

                        s.more.Text = "Forward to Worker";
                        s.more.Enabled = true;

                        r.Updatestatus_Seen(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = r.Get_All_all();
                    }
                    if (Program.type == 2)
                    {
                        s.more.Enabled = false;
                    }
                 
                  

                }

                s.button2.Hide();
                s.Show();
                }
                if(Program.type==3)
                {
                    s.label6.Text = Dt.Rows[0]["sender_Report_ID"].ToString();
                    s.label7.Text = Dt.Rows[0]["Department_Name"].ToString();
                    s.more.Text = "Report Details about solving";
                    s.label8.Text = Dt.Rows[0]["sentDate"].ToString();
                    s.label9.Text = Dt.Rows[0]["Title"].ToString();
                    s.label10.Text = Dt.Rows[0]["Details"].ToString();
                    s.label11.Text = Dt.Rows[0]["status_Name"].ToString();
                    s.label13.Text = Dt.Rows[0]["Major_Name"].ToString();
                    
                    s.label13.Visible = true;
                    s.label16.Visible = true;
                    if (s.label11.Text == "On Doing" || s.label11.Text == "Assigned")
                    {
                        s.more.Enabled = true;
                        s.more.Text = "Write final Report";
                  
                    if (s.label11.Text == "Assigned")
                    {
                       
                        s.button2.Enabled = true;

                    }
                    }
                    else
                        if (s.label11.Text == "Not Done" || s.label11.Text == "Done")
                    {
                        s.more.Text = "Report Details about solving";
                        s.more.Enabled = true;
                      
                    }
                    s.Show();
                }
              
            }
        }
    }
}
       