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
    public partial class FRM_Sender : Form
    {
        BL.CLS_Emp Emp = new BL.CLS_Emp();
        public FRM_Sender()
        {
            InitializeComponent();
            cmbtype.DataSource = Emp.Get_All_dept();
            cmbtype.DisplayMember = "Department_name";
            cmbtype.ValueMember = "Department_ID";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Emp.Addsender(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(cmbtype.SelectedValue), textBox3.Text, textBox4.Text,2);

              
                
                MessageBox.Show("Add Seccess", "Add Sender ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = Emp.Get_All_senders();

                textBox1.Text = Emp.maxsender().Rows[0][0].ToString();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
               
            }
        }

        private void FRM_Sender_Load(object sender, EventArgs e)
        {
            textBox1.Text = Emp.maxsender().Rows[0][0].ToString();

            button1.Enabled = true;
            button2.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Emp.Get_All_senders();


           


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                Emp.Updatesender(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(cmbtype.SelectedValue), textBox3.Text, textBox4.Text, 2);

                MessageBox.Show("Update Seccess", "Update Sender", MessageBoxButtons.OK, MessageBoxIcon.Information);
              this.dataGridView1.DataSource = Emp.Get_All_senders();
                textBox1.Text = Emp.maxsender().Rows[0][0].ToString();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Emp.maxsender().Rows[0][0].ToString();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
