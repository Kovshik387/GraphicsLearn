using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GraphicsLearn.Task_2
{
    public class DrawBitMap
    {
        Brush brush;
        Rectangle rectangle;
        Pen _blackPen = new Pen(Color.Black, 10f);

        public void Print(Graphics graphics)
        {
            brush = new SolidBrush(Color.Yellow);
            rectangle = new Rectangle(350, 350, 300, 300);

            graphics.FillEllipse(brush, rectangle);
            graphics.DrawEllipse(new Pen(Color.Black,10f),rectangle);

            graphics.DrawLine(_blackPen, 360, 450, 640, 450);
            
            graphics.DrawLine(_blackPen, 450, 570, 550, 570);
            
            graphics.DrawLine(_blackPen, 555, 565, 555, 555);

            for (int i = 0; i < 100; i += 25)
            {
                graphics.DrawLine(_blackPen, 430 + i * 2, 455 , 430+ i * 2, 490);
            }
            for (int i = 0; i < 150; i+= 75)
            {
                graphics.DrawLine(_blackPen, 435 + i, 495, 475 + i, 495);
                i += 25;
            }
            for (int i = 0; i < 190; i += 100)
            {
                graphics.FillRectangle(new SolidBrush(Color.Black), 430 + i, 455, 50, 40);
                graphics.FillRectangle(new SolidBrush(Color.White), 430 + i, 455, 20, 20);
            }

        }
        
    }
}
