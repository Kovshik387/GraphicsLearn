using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLearn
{
    public partial class Task3 : Form
    {
        public Graphics g;
        public Bitmap map;
        public Pen p;

        public double angle = Math.PI / 2;
        private double _angle45 = 0;
        private double _angle60 = 0;

        private const double _k = 0.7;

        public Task3()
        {
            InitializeComponent();
        }
        public void DrawTree(double x, double y, double a, double angle)
        {
            if (a > (int)Iter.Value)
            {
                a *= _k;
                
                double xnew = Math.Round(x + a * Math.Cos(angle)),
                       ynew = Math.Round(y - a * Math.Sin(angle));

                g.DrawLine(p, (float)x, (float)y, (float)xnew, (float)ynew);

                DrawTree(xnew, ynew, a, angle - this._angle60);
                DrawTree(xnew, ynew, a, angle + this._angle45);
            }
        }

        public void PrintPythagor()
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(map);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Black, 2);

            DrawTree(pictureBox1.Width / 2, pictureBox1.Height, trackBar1.Value, this.angle);

            pictureBox1.BackgroundImage = map;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
