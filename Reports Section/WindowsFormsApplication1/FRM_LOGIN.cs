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

    public partial class FRM_LOGIN : Form
    {

        BL.CLS_LogIn log = new BL.CLS_LogIn();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txt_name.Text, txt_pass.Text);
            DataTable Dt2 = log.LOGIN_worker(txt_name.Text, txt_pass.Text);
            if (Dt.Rows.Count > 0)
            {

                Program.section = Convert.ToInt32(Dt.Rows[0]["Department_ID"]);
                   Program.type = Convert.ToInt32(Dt.Rows[0]["TypeID"]);
                    Program.empname = Dt.Rows[0]["sender_Name"].ToString();


                    FRM_MAIN.getMainForm.workersToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.workerManagementToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.workerMajorToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.addUsersToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.uToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.usersToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.departmentToolStripMenuItem.Enabled = false;


                    FRM_MAIN.getMainForm.majorReportsToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.receivedReportsToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.receiverSectionToolStripMenuItem.Enabled = false;
                   

                    FRM_MAIN.getMainForm.reportsToolStripMenuItem1.Enabled = true;

                    FRM_MAIN.getMainForm.reportsToolStripMenuItem.Enabled = true;

                    FRM_MAIN.getMainForm.workerReportToolStripMenuItem.Enabled = true;
                  

              this.Close();

              
            }
            else if (Dt2.Rows.Count > 0)
            {
                Program.type = Convert.ToInt32(Dt2.Rows[0]["TypeID"]);
                 Program.section = Convert.ToInt32(Dt2.Rows[0]["Major_ID"]);
                 Program.empname = Dt2.Rows[0]["worker_Name"].ToString();
                if(Program.type==1)
                {

                    FRM_MAIN.getMainForm.workersToolStripMenuItem.Enabled = true;

                    FRM_MAIN.getMainForm.workerManagementToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.workerMajorToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.addUsersToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.uToolStripMenuItem.Enabled = true;

                    FRM_MAIN.getMainForm.usersToolStripMenuItem.Enabled = true;
                  
                    FRM_MAIN.getMainForm.departmentToolStripMenuItem.Enabled = true;

                    FRM_MAIN.getMainForm.majorReportsToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.receivedReportsToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.receiverSectionToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.reportsToolStripMenuItem1.Enabled = false;

                    FRM_MAIN.getMainForm.reportsToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.workerReportToolStripMenuItem.Enabled = false;

                }
                else if (Program.type == 3)
                {
                    FRM_MAIN.getMainForm.majorReportsToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.receivedReportsToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.receiverSectionToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.reportsToolStripMenuItem1.Enabled = false;

                    FRM_MAIN.getMainForm.reportsToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.workerReportToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.workersToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.workerManagementToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.workerMajorToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.addUsersToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.uToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.usersToolStripMenuItem.Enabled = false;

                    FRM_MAIN.getMainForm.departmentToolStripMenuItem.Enabled = false;

                }
                this.Close();

        
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
    }
}
