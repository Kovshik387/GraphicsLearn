using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLearn
{
    public partial class Task3 : Form
    {
        public Graphics g;
        public Bitmap map;
        public Pen p;

        public double angle = 0.5;
        private double _angle45 = Math.PI / 4;
        private double _angle60 = Math.PI / 4;

        private const double _k = 0.7;
        private const int _deep = 15;

        public Task3()
        {
            InitializeComponent();
        }
        public void DrawTree(double x1,double y1, double x2, double y2, int deep)
        {
            if (deep >= Iter.Value) return;

            double dx = x2 - x1;
            double dy = y1 - y2;
            double x3 = x2 - dy;
            double y3 = y2 - dx;
            double x4 = x1 - dy;
            double y4 = y1 - dx;

            double x5 = x4 + this.angle * (dx - dy);
            double y5 = y4 - this.angle * (dx + dy);

            Point[] points = { new Point((int)x1, (int)y1), new Point((int)x2, (int)y2), new Point((int)x2, (int)y2),
                new Point((int)x3, (int)y3),new Point((int)x3, (int)y3),new Point((int)x4, (int)y4),new Point((int)x4, (int)y4), new Point((int)x1, (int)y1)};

            g.DrawLines(p, points);

            DrawTree(x4, y4, x5, y5, deep + 1);
            DrawTree(x5, y5, x3, y3, deep + 1);

        }

        public void PrintPythagor()
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(map);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Black, 2);

            DrawTree(pictureBox1.Width / 2 - 50, pictureBox1.Height, pictureBox1.Width/2 + 50, pictureBox1.Height,0);
            pictureBox1.BackgroundImage = map;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._angle45 = Math.PI / 4; this._angle60 = Math.PI / 4;
            PrintPythagor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._angle45 = Math.PI / 4; this._angle60 = Math.PI / 6;
            PrintPythagor();
        }

        private void Task3_ResizeEnd(object sender, EventArgs e) => PrintPythagor();

    }
}
