using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp5
{
    public class Highway
    {
        Random rnd = new Random();
        public List<Line> lines=new List<Line>();
        public Highway(int count)
        {
            for (int i = 0; i < count; i++)
                lines.Add(new Line());
        }
        public Car Add()
        {
            Car c = new Car();
            lines[rnd.Next(lines.Count)].cars.Add(c);
            return c;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            g.Clear(Color.White);
            for (int i = 0; i < lines.Count; i++)
                lines[i].Draw(g, i);
        }
    }
}
