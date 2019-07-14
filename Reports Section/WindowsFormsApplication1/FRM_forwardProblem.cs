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
    
    public partial class FRM_forwardProblem : Form
    {
        BL.CLS_Emp Emp = new BL.CLS_Emp();
        BL.CLS_Reports r = new BL.CLS_Reports();
        public FRM_forwardProblem(string x)
        {
            InitializeComponent();
            comboBox1.DataSource = Emp.Get_All_major();
            comboBox1.DisplayMember = "Major_Name";
            comboBox1.ValueMember = "Major_ID";
            textBox1.Text = x;
        }

        private void FRM_forwardProblem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                r.Updateforwardreport(Convert.ToInt32(textBox1.Text), Convert.ToInt32(comboBox1.SelectedValue));
                MessageBox.Show("Forward Sucess", "Forward Report ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
