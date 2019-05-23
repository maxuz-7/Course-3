using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_kr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (numericUpDown1.Value > 1)
            {
                numericUpDown1.Value = numericUpDown1.Value - 1;
                if (c == 0)
                textBox1.Text = (numericUpDown1.Value).ToString();
                else
                textBox2.Text = (numericUpDown1.Value).ToString();
            }

            else
            {
                numericUpDown1.Value = 5;
                textBox1.Text = (numericUpDown1.Value).ToString();
                if (c == 0)
                {
                    textBox2.Text = (numericUpDown1.Value).ToString();
                    textBox1.Text = "WALK";
                    textBox1.ForeColor = Color.Green;
                    textBox2.ForeColor = Color.Green;
                    c = 1;
                }
                else
                {
                    textBox1.Text = (numericUpDown1.Value).ToString();
                    textBox1.ForeColor = Color.Red;
                    textBox2.ForeColor = Color.Red;
                    textBox2.Text = "DON'T WALK";
                    c = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int d = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(a==1)
            {
            if (numericUpDown1.Value <= 3)
            {
                if (d == 0)
                {
                    textBox1.ForeColor = Color.Black;
                    textBox2.ForeColor = Color.Black;
                    d = 1;
                }

                else
                {
                    if (c == 0)
                    {
                        textBox1.ForeColor = Color.Red;
                        textBox2.ForeColor = Color.Red;
                    }
                    else
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox2.ForeColor = Color.Green;
                    }
                    d = 0;
                }
            }
            }
        }
        int a = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                a = 1;
            else a = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
