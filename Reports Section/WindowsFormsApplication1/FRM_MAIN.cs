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
    public partial class FRM_MAIN : Form
    {
        BL.CLS_Reports r = new BL.CLS_Reports();
        private static FRM_MAIN frm;
        static void frm_FormClosed(object sender , FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm==null)
                {
                    frm = new FRM_MAIN(Program.empname);
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_MAIN(string x)
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.workersToolStripMenuItem.Enabled = false;
            this.workerManagementToolStripMenuItem.Enabled = false;
            this.workerMajorToolStripMenuItem.Enabled = false;
            this.usersToolStripMenuItem.Enabled = false;
            this.addUsersToolStripMenuItem.Enabled = false;
            this.reportsToolStripMenuItem.Enabled = false;
            this.reportsToolStripMenuItem1.Enabled = false;
            this.workerReportToolStripMenuItem.Enabled = false;
            this.departmentToolStripMenuItem.Enabled = false;
            this.uToolStripMenuItem.Enabled = false;
            this.majorReportsToolStripMenuItem.Enabled = false;
            this.receivedReportsToolStripMenuItem.Enabled = false;
            this.receiverSectionToolStripMenuItem.Enabled = false;
            toolStripStatusLabel1.Text = "TODAY IS: " + DateTime.Now + "                    PC :" + Environment.MachineName + "                               employee Name:" +x + "";
        }
      


       


        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FRM_SenderReport f = new FRM_SenderReport();
            f.Show();
        }

        private void workerReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRM_SenderViewReport f = new FRM_SenderViewReport();
            f.Show();
        }

        private void workerManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRM_WORKER_MANAGMENT f = new FRM_WORKER_MANAGMENT();
            f.Show();
        }

        private void workerMajorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRM_WORKER_MAJOR f = new FRM_WORKER_MAJOR();
            f.Show();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Sender f = new FRM_Sender();
            f.Show();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DEPARTMENT f = new FRM_DEPARTMENT();
            f.Show();
        }

        private void departmentProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SenderViewReport m = new FRM_SenderViewReport();
            m.Show();
            m.dataGridView1.AutoGenerateColumns = false;
                   m.dataGridView1.DataSource = r.Get_All_recevedbymanage();

                   m.button2.Hide();
                   m.button3.Hide();
                   m.button4.Hide();
                   m.button5.Hide();
                   m.button6.Hide();
                   m.button7.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SenderViewReport m = new FRM_SenderViewReport();
            m.Show();
            m.dataGridView1.AutoGenerateColumns = false;
            m.dataGridView1.DataSource = r.Get_All_all();
         
        }

        private void receivedReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SenderViewReport m = new FRM_SenderViewReport();
            m.Show();
            m.dataGridView1.AutoGenerateColumns = false;
            m.dataGridView1.DataSource = r.Get_All_ReceiverAssigned();
            m.button2.Hide();
            m.button3.Hide();
            m.button4.Hide();
            m.button5.Hide();
            m.button6.Hide();
            m.button7.Hide();

        }

        private void majorReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SenderViewReport m = new FRM_SenderViewReport();
            m.Show();
            m.dataGridView1.AutoGenerateColumns = false;
            m.dataGridView1.DataSource = r.Get_All_Receiverall();
            m.button7.Hide();
        }

        private void receiverSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
          
        }






    }
}
