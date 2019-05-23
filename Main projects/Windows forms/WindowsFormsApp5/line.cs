using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp5
{
   public class Line
    {
        public List<Car> cars = new List<Car>();

        public Car Car
        {
            get => default(Car);
            set
            {
            }
        }

        public void Draw(Graphics g, int a)
        {
                Brush b = new SolidBrush(Color.FromArgb(200, 200, 200));
                Rectangle rect = new Rectangle(0, a * 50, 1090, 48);
                g.FillRectangle(b, rect);
            
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].Draw(g, a * 50);
            }
        }
    }
}
