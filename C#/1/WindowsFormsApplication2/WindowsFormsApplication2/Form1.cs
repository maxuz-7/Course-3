using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X, Y, Z = 0;
            try
            {
                X = int.Parse(textBox1.Text);
                Y = int.Parse(textBox2.Text);
                switch(comboBox1.SelectedIndex)
                {
                    case 0:
                         Z = X + Y;
                        break;
                    case 1:
                        Z=X-Y;
                        break;
                    case 2:
                        Z=X*Y;
                        break;
                    case 3:
                        Z=X/Y;
                        break;
                }
                textBox3.Text = Z.ToString();
            }
                catch(DivideByZeroException errr)
            {
                    MessageBox.Show( "Деление на 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    textBox1.SelectAll();
                    textBox3.Text = "gff";
                }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "\r\n" +
                    err.StackTrace,
                    err.GetType().FullName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
