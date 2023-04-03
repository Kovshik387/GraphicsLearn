using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLearn.Task_4
{
    internal class LogicTask4
    {
        public static void PrintLines(Graphics graphics, List<Bezier> bezires,Boolean check)
        {
            if (check)
            {
                foreach (var item in bezires)
                {
                    graphics.DrawBezier(new Pen(Color.Black,3), item.Start, item.Control1, item.Control2, item.Finish);

                    graphics.FillEllipse(new SolidBrush(Color.Green), item.Start.X - 5, item.Start.Y - 5, 11, 11);
                    graphics.FillEllipse(new SolidBrush(Color.Green), item.Control1.X - 5, item.Control1.Y - 5, 11, 11);
                    graphics.FillEllipse(new SolidBrush(Color.Green), item.Control2.X - 5, item.Control2.Y - 5, 11, 11);
                    graphics.FillEllipse(new SolidBrush(Color.Green), item.Finish.X - 5, item.Finish.Y - 5, 11, 11);
                    graphics.DrawLine(new Pen(Color.Green, 3) { StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor, EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor }, item.Start, item.Control1);
                    graphics.DrawLine(new Pen(Color.Green, 3) { StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor, EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor }, item.Finish, item.Control2);
                }

            }
            else foreach (var item in bezires) graphics.DrawBezier(new Pen(Color.Black, 3),item.Start, item.Control1, item.Control2, item.Finish);

            graphics.FillEllipse(new SolidBrush(Color.Black),630,200,5,5);
            graphics.FillEllipse(new SolidBrush(Color.Black), 610, 200, 5, 5);
            
            // 840 // 460
            //graphics.FillEllipse(new Pen(Color.Black,5),)
        }
    }
}
