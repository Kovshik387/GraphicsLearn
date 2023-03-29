using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
                    graphics.DrawLine(new Pen(Color.Green, 3) { StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor, EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor }, item.Control1, item.Control2);
                }
            }
            else foreach (var item in bezires) graphics.DrawBezier(new Pen(Color.Black, 3),item.Start, item.Control1, item.Control2, item.Finish);

            graphics.DrawCurve()
        }
    }
}
