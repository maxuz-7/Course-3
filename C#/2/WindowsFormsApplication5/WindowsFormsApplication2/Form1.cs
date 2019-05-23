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

        private void Form1_Load(object sender, EventArgs e)
        {
            pbO.Left = X - 2;
            pbO.Top = Y - 2;
            pb.Left = (int)(X + R - pb.Width / 2);
            pb.Top = (int)(Y + R - pb.Height / 2);
            tbx.Text = X.ToString();
            tby.Text = Y.ToString();
            tbr.Text = R.ToString();
        }
        double alpha = 0.0;
        int X = 100, Y = 100, R = 150;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(cb1.Checked)
            alpha += 0.05;
            else alpha -= 0.05;
            pb.Left = (int)(X + R * Math.Cos(alpha))-pb.Width/2;
            pb.Top = (int)(Y + R * Math.Sin(alpha))-pb.Height/2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            alpha = 0.0;
            pb.Left = (int)(X + R * Math.Cos(alpha)) - pb.Width / 2;
            pb.Top = (int)(Y + R * Math.Sin(alpha)) - pb.Height / 2;
            timer1.Enabled = false;

        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            X = (int.Parse(tbx.Text));
            pbO.Left = X - 2;

        }

        private void tby_TextChanged(object sender, EventArgs e)
        {
            Y = (int.Parse(tby.Text));
            pbO.Top = Y - 2;
        }

        private void tbr_TextChanged(object sender, EventArgs e)
        {
            R = (int.Parse(tbr.Text));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int ox, oy;
        bool mouse_down = false, fly;
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down = true;
            fly = timer1.Enabled;
            timer1.Stop();
            ox = e.X;
            oy = e.Y;
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouse_down)
            {
                pb.Top += e.Y - oy;
                pb.Left += e.X - ox;
            }
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            int xx = pb.Left + pb.Width / 2;
            int yy = pb.Top + pb.Height / 2;
            R = (int)(Math.Sqrt((xx - X) * (xx - X) + (yy - Y) * (yy - Y)));
            tbr.Text = R.ToString();
            if (xx > X)
                alpha = Math.Atan(((double)Y - yy) / (X - xx));
            else if (xx < X)
                alpha = Math.PI + Math.Atan(((double)Y - yy) / (X - xx));
            else //xx=X
                alpha = Math.Sign(Y - yy)*Math.PI/2;
            mouse_down = false;
            timer1.Enabled=fly;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }
        private void pbO_Click(object sender, EventArgs e)
        {
           

        }
        int ox1, oy1;
        bool mouse_down1 = false, fly1;
        private void pbO_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_down1 = true;
            fly1 = timer1.Enabled;
            timer1.Stop();
            ox1 = e.X;
            oy1 = e.Y;
            pbO.BackColor = Color.Red;
        }

        private void pbO_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_down1)
            {
                pbO.Top += e.Y - oy1;
                pbO.Left += e.X - ox1;
                pb.Left += e.X - ox1;
                pb.Top += e.Y - oy1;
            }


        }

        private void pbO_MouseUp(object sender, MouseEventArgs e)
        {
            pbO.BackColor = Color.Black;
            int xx1 = pbO.Left + pbO.Width / 2;
            int yy1 = pbO.Top + pbO.Width / 2;
            X = xx1;
            Y = yy1;
            tbx.Text = X.ToString();
            tby.Text = Y.ToString();
            mouse_down1 = false;
            timer1.Enabled = fly1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
            trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
