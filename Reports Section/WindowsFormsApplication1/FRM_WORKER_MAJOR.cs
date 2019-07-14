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
    public partial class FRM_WORKER_MAJOR : Form
    {
        BL.CLS_Emp s = new BL.CLS_Emp();
        public FRM_WORKER_MAJOR()
        {
            InitializeComponent();
        }

        private void FRM_WORKER_MAJOR_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            textBox1.Text = s.maxmajor().Rows[0][0].ToString();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = s.Get_All_major();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.AddMajor(Convert.ToInt32(textBox1.Text), textBox2.Text);
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_major();
                textBox2.Clear();
                textBox1.Text = s.maxmajor().Rows[0][0].ToString();

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You Cant do anything if the boxes are empty  ", "Warning  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                s.UpdateMajor(Convert.ToInt32(textBox1.Text), textBox2.Text);
                MessageBox.Show("Add Seccess", "Add Product ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = s.Get_All_major();
                textBox2.Clear();
                textBox1.Text = s.maxmajor().Rows[0][0].ToString();
                button1.Enabled = true;
                button2.Enabled = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = s.maxmajor().Rows[0][0].ToString();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
