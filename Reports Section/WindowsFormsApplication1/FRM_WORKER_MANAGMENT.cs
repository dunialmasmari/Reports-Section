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
    public partial class FRM_WORKER_MANAGMENT : Form
    {
        BL.CLS_Emp Emp = new BL.CLS_Emp();
        public FRM_WORKER_MANAGMENT()
        {
            InitializeComponent();
            comboBox1.DataSource = Emp.Get_All_type();
            comboBox1.DisplayMember = "TypeName";
            comboBox1.ValueMember = "TypeID";
            cmbmajor.DataSource = Emp.Get_All_major();
            cmbmajor.DisplayMember = "Major_Name";
            cmbmajor.ValueMember = "Major_ID";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_WORKER_MANAGMENT_Load(object sender, EventArgs e)
        {
            textBox1.Text = Emp.maxworker().Rows[0][0].ToString();

            button1.Enabled = true;
            button2.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Emp.Get_All_worker();

        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            textBox3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            textBox4.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            cmbmajor.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
            textBox5.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[5].Value);
            textBox6.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[6].Value);
            comboBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[7].Value);
          
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Emp.maxworker().Rows[0][0].ToString();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Emp.Addworker(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(cmbmajor.SelectedValue), textBox5.Text, textBox6.Text, Convert.ToInt32(comboBox1.SelectedValue));



                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = Emp.Get_All_worker();

                textBox1.Text = Emp.maxworker().Rows[0][0].ToString();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Emp.Updateworker(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(cmbmajor.SelectedValue), textBox5.Text, textBox6.Text, Convert.ToInt32(comboBox1.SelectedValue));



                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = Emp.Get_All_worker();

                textBox1.Text = Emp.maxworker().Rows[0][0].ToString();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                button1.Enabled = true;
                button2.Enabled = false;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
