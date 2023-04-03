using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLearn.Task_4
{
    public partial class Task4 : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private List<Bezier> beziers;
        public Task4()
        {
            InitializeComponent();

            this.bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.graphics = Graphics.FromImage(bitmap);
            this.graphics.SmoothingMode = this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }

        private void Task4_Load(object sender, EventArgs e)
        {
            this.beziers = new List<Bezier>();

            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2 - 40, this.pictureBox1.Height - 53), new Point(this.pictureBox1.Width / 2 - 60, this.pictureBox1.Height - 45), new Point(this.pictureBox1.Width / 2 + 50, this.pictureBox1.Height - 60), new Point(this.pictureBox1.Width / 2 + 40, this.pictureBox1.Height - 40))); // нижняя часть
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2 - 40, this.pictureBox1.Height - 51), new Point(80, this.pictureBox1.Height / 2 + 40), new Point(this.pictureBox1.Width / 2 - 100, 10), new Point(this.pictureBox1.Width / 2 - 10, 120))); // левая часть
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2 + 40, this.pictureBox1.Height - 42), new Point(this.pictureBox1.Width - 80, this.pictureBox1.Height / 2 - 40), new Point(this.pictureBox1.Width / 2 + 100, 10), new Point(this.pictureBox1.Width / 2 + 10, 120))); // права часть
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2 - 110, this.pictureBox1.Height - 150), new Point(this.pictureBox1.Width / 2 - 130, this.pictureBox1.Height - 120), new Point(this.pictureBox1.Width / 2 - 120, this.pictureBox1.Height / 2), new Point(this.pictureBox1.Width / 2 - 90, this.pictureBox1.Height / 2 - 60))); //
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2, 120), new Point(this.pictureBox1.Width / 2, 100), new Point(this.pictureBox1.Width / 2, 10), new Point(this.pictureBox1.Width / 2 + 20, 10)));

            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2, 100), new Point(this.pictureBox1.Width / 2 - 10, 80), new Point(this.pictureBox1.Width / 2 + 10, 30), new Point(this.pictureBox1.Width / 2 + 90, 20)));
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2, 100), new Point(this.pictureBox1.Width / 2 - 10, 48), new Point(this.pictureBox1.Width / 2 + 60, 60), new Point(this.pictureBox1.Width / 2 + 90, 20)));

            //Червяк
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2 + 40, this.pictureBox1.Height /2 + 50 ), new Point(this.pictureBox1.Width / 2 + 90, this.pictureBox1.Height / 2 + 50), new Point(this.pictureBox1.Width / 2 + 200, this.pictureBox1.Height / 2 + 40), new Point(this.pictureBox1.Width / 2 + 260, this.pictureBox1.Height / 2 - 20)));
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2 + 20 , this.pictureBox1.Height / 2 + 30), new Point(this.pictureBox1.Width / 2 + 10, this.pictureBox1.Height / 2), new Point(this.pictureBox1.Width / 2 + 280, this.pictureBox1.Height / 2 - 60), new Point(this.pictureBox1.Width / 2 + 260, this.pictureBox1.Height / 2 -20)));
            beziers.Add(new Bezier(new Point(this.pictureBox1.Width / 2 + 190, this.pictureBox1.Height / 2), new Point(this.pictureBox1.Width / 2 + 110,this.pictureBox1.Height / 2 + 20), new Point(this.pictureBox1.Width / 2 + 220, this.pictureBox1.Height / 2 + 20), new Point(this.pictureBox1.Width / 2 + 210, this.pictureBox1.Height / 2 )));

            LogicTask4.PrintLines(this.graphics, beziers, Show_Control.Checked);
            this.pictureBox1.Image = this.bitmap;
        }

        private void Show_Control_CheckedChanged(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            LogicTask4.PrintLines(this.graphics, beziers, Show_Control.Checked);
            this.pictureBox1.Image = this.bitmap;
        }
    }
}
