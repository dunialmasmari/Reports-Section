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

    public partial class FRM_SentReportDetails : Form
    {
        BL.CLS_Reports r = new BL.CLS_Reports();

        public FRM_SentReportDetails()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FRM_SentReportDetails_Load(object sender, EventArgs e)
        {



        }

        private void more_Click(object sender, EventArgs e)
        {
            if (more.Text == "Report Details about solving")
            {
                FRM_Reports s = new FRM_Reports();

                DataTable Dt = r.Get_All_moredetails(Convert.ToInt32(label6.Text));
                if (Dt.Rows.Count > 0)
                {

                    s.label6.Text = Dt.Rows[0]["sender_Report_ID"].ToString();
                    s.label7.Text = Dt.Rows[0]["Department_Name"].ToString();
                    s.label8.Text = Dt.Rows[0]["sentDate"].ToString();
                    s.label9.Text = Dt.Rows[0]["Title"].ToString();
                    s.label10.Text = Dt.Rows[0]["Details"].ToString();
                    s.label11.Text = Dt.Rows[0]["status_Name"].ToString();
                    s.label13.Text = Dt.Rows[0]["Major_Name"].ToString();
                    s.label14.Text = Dt.Rows[0]["solvername"].ToString();
                    s.label15.Text = Dt.Rows[0]["workerfinalReport"].ToString();

                   

                }
                s.Show();
            }
            if(more.Text=="Forward to Worker")
            {
             
                FRM_forwardProblem f = new FRM_forwardProblem(label6.Text);
                f.Show();
               

            }
            if (more.Text == "Write final Report")
            {
                FRM_WORKER_REPORT f = new FRM_WORKER_REPORT(label6.Text);
                f.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r.Updatestatusondoing(Convert.ToInt32(label6.Text));

          
            button2.Enabled = false;
        }
    }
}