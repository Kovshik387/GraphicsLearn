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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            graphics.Clear(Color.White);
            var drawBitMap = new Task_2.DrawBitMap();
            drawBitMap.Print(graphics);
        }
    }
}
