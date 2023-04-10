extern alias global1;
using global1::Tao.Platform.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;


namespace GraphicsLearn.Task_6
{
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
            View3d.InitializeContexts();

            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            Gl.glClearColor(255, 255, 255, 1);

            Gl.glViewport(0, 0, View3d.Width, View3d.Height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)View3d.Width / (float)View3d.Height, 0.1, 200);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void ShowView_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(1f,0,4f);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, -3);
            Gl.glRotated(-30, 1, 0, 0);
            Gl.glRotated(45, 0, 1, 0);
            Glut.glutSolidSierpinskiSponge(7,new double[] {0,0,0} ,1);
            Gl.glPopMatrix();
            Gl.glFlush();
            View3d.Invalidate();
        }
    }
}
