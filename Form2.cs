using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCheck
{
    public partial class Form2 : Form
    {
        Form1 mainform;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainform=form1;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            mainform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (DataGridViewRow row in mainform.dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    if (row.Cells[0].Value.ToString() == textBox1.Text )
                    {
                        found = true;
                        if (richTextBox1.Text.Contains(textBox1.Text))
                        {
                            MessageBox.Show("User already found");
                        }
                        else { 
                            richTextBox1.AppendText("username: " + row.Cells[0].Value.ToString() +
                                                    " password: " + row.Cells[1].Value.ToString() +
                                                    " registration date: " + row.Cells[2].Value.ToString() + "\n");
                        }break;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("User not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
