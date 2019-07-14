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
    public partial class FRM_DEPARTMENT : Form
    {
        BL.CLS_Emp s = new BL.CLS_Emp();
        public FRM_DEPARTMENT()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.AddDept(Convert.ToInt32(textBox1.Text), textBox2.Text);
                MessageBox.Show("Department Added Seccessfully", "Add New Department ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_dept();
                textBox2.Clear();
                textBox1.Text = s.maxdept().Rows[0][0].ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.UpdateDept(Convert.ToInt32(textBox1.Text), textBox2.Text);
                MessageBox.Show("Department Updated  Seccessfully", "Update  Department ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_dept();
                textBox2.Clear();
                textBox1.Text = s.maxdept().Rows[0][0].ToString();

            }
        }

        private void FRM_DEPARTMENT_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Text = s.maxdept().Rows[0][0].ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = s.Get_All_dept();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = s.maxdept().Rows[0][0].ToString();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
