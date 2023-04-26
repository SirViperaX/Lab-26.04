using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_26._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyGraphics g =  new MyGraphics();
        Map demo = new Map();
        private void Form1_Load(object sender, EventArgs e)
        {
            g.InitGraph(pictureBox1);
            demo.width = pictureBox1.Width;
            demo.height = pictureBox1.Height;
            demo.Init(50);
            demo.Draw(g.grp);
            g.RefreshGraph();
        }
    }
}
