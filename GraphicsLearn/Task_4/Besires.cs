using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLearn.Task_4
{
    public class Bezier
    {
        public Point Start { get; set; }
        public Point Control1 { get; set; }
        public Point Control2 { get; set; }
        public Point Finish { get; set; }
        public Bezier(Point Start,Point Control1,Point Control2, Point Finish)
        {
            this.Start = Start; this.Control1 = Control1; this.Control2 = Control2; this.Finish = Finish;
        }
    }
}
