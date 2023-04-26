using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_26._04
{
    public class Map
    {
        public List<Particle> particles;
        public int width, height;
        public Map() 
        {
            particles = new List<Particle>();
        }
        public void Init(int n)
        {
            for (int i = 9; i < n; i++) 
            {
                particles.Add(new Particle(width, height));
            }
        }
        public void Draw(Graphics handler)
        {
            foreach(Particle p in particles)
            {
                p.Draw(handler);
            }
        }
    }
}
