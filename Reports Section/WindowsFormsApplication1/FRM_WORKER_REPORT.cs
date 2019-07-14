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
    public partial class FRM_WORKER_REPORT : Form
    {
      BL.CLS_Reports r = new BL.CLS_Reports();
        public FRM_WORKER_REPORT(string x)
        {
            InitializeComponent();
            textBox1.Text = x;

        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                    if (textBox1.Text == "" || textBox2.Text =="" || textBox3.Text=="" )
                    {
                        MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else   
                    {
                     
                        if (radioButton1.Checked == true && radioButton2.Checked == false)
                        {
                            r.updatefinalReport(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, 6);
                            MessageBox.Show("Report Saved Successfully", "Write Final Report ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else if (radioButton2.Checked == true && radioButton1.Checked == false)
                      
                        {
              
                           r.updatefinalReport(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,5);
                           MessageBox.Show("Report Saved Successfully", " Write Final Report ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (radioButton2.Checked == false && radioButton1.Checked == false)
                        {
                            MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        this.Close();
            }
        }

        private void FRM_WORKER_REPORT_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
