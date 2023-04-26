using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_26._04
{
    public class Particle
    {
        public static Random rnd = new Random();
        static int rataDisp = 20, rataDubl = 30, radius = 30, nr = 3;
        PointF location;
        bool forDeletion;
        public Particle(int wMax, int hMax)
        {
            forDeletion = false;
            location = new PointF(rnd.Next(wMax), rnd.Next(hMax));
        }
        public void Draw(Graphics handler)
        {
            handler.DrawEllipse(Pens.Black, location.X - 3, location.Y - 3, 7, 7);

        }
    }
}
