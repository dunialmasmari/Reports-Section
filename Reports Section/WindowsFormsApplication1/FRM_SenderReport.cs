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
    public partial class FRM_SenderReport : Form
    {
        BL.CLS_Reports r = new BL.CLS_Reports();
        public FRM_SenderReport()
        {
            InitializeComponent();
            textBox1.Text = r.maxsenderReport().Rows[0][0].ToString();
            textBox2.Text = Program.section.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                r.AddsenderReport(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),Convert.ToDateTime( dateTimePicker1.Text), textBox3.Text, textBox4.Text);



                MessageBox.Show("Add Seccess", "Add Report ", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

                textBox1.Text = r.maxsenderReport().Rows[0][0].ToString();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
        }

        private void FRM_SenderReport_Load(object sender, EventArgs e)
        {
            textBox1.Text = r.maxsenderReport().Rows[0][0].ToString();
            textBox2.Text =Convert.ToString( Program.section);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
