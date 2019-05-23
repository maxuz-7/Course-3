using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(r.Next(10), r.Next(10));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butdel_Click(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 0)
                chart1.Series[0].Points.RemoveAt(chart1.Series[0].Points.Count - 1);
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }

        private void butAdd1_Click(object sender, EventArgs e)
        {
            Series s = new Series();
            s.ChartType = SeriesChartType.Point;
            s.MarkerSize = (int)(numericUpDown2.Value);
            for (int i = 0; i < 10; i++)
                s.Points.AddXY(r.Next(5, 15), r.Next(10));
            chart1.Series.Add(s);
        }

        private void butDel1_Click(object sender, EventArgs e)
        {
            while (chart1.Series.Count > 1)
                chart1.Series.RemoveAt(1);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < chart1.Series.Count; i++)
                chart1.Series[i].MarkerSize = (int)(numericUpDown2.Value);
        }

        private void CBline_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = CBline.SelectedIndex + 1;
        }

        private void CBline_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Pen p = new Pen(chart1.Series[0].Color, e.Index + 1);
            int c=(e.Bounds.Top+e.Bounds.Bottom)/2;
            e.Graphics.DrawLine(p,e.Bounds.Left,c,e.Bounds.Right,c);
        }
        Color[] cs = new Color[7]
        {
            Color.Aquamarine,
            Color.Brown,
            Color.Coral,
            Color.Crimson,
            Color.Black,
            Color.AntiqueWhite,
            Color.CadetBlue
        };
        private void CBcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series[0].Color = cs[CBcolor.SelectedIndex];
        }

        private void CBcolor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.Graphics.FillRectangle(new SolidBrush(cs[e.Index]), e.Bounds);
        }

        private void chart1_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBcolor.SelectedIndex = 1;
            CBline.SelectedIndex = 3;
        }
    }
}
