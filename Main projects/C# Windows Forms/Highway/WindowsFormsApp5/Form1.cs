using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public int a = 0, m = 5, n = 0, t = 40, maxv, minv, wt;
        public Highway hg=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wt = (int)numericUpDown5.Value;
            minv = (int)numericUpDown4.Value;
            maxv = (int)numericUpDown3.Value;
            numericUpDown5.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            t = (int)numericUpDown2.Value;
            timer1.Interval = t;
            numericUpDown2.ReadOnly = true;
            m = (int)numericUpDown1.Value;
            hg = new Highway(m);
            numericUpDown1.ReadOnly = true;
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(hg!=null)
            hg.Draw(e.Graphics);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        hg.Hgtick1(++a, minv, maxv, wt);
            
                n =hg.r;
            label1.Text = n.ToString();
            label4.Text = hg.k.ToString();
            panel1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
