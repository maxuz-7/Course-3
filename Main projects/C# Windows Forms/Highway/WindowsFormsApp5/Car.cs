using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp5
{
    public class Car
    {
        Random rnd = new Random();
        public double speed, x;
        public int w;
        public Car(int g, int h)
        {
            w = 0;
            speed = rnd.Next(g, h);
            x = -5;
        }
        public void Draw(Graphics g, int y)
        {
            Brush b = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle((int)x, y+10, 30, 20);
            g.FillRectangle(b, rect);
        }
    }
}
