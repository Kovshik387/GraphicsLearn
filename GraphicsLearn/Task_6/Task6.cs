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
using Tao.DevIl;
using static System.Net.Mime.MediaTypeNames;

namespace GraphicsLearn.Task_6
{
    public partial class Task6 : Form
    {
        enum Primitives
        {
            None = 0,
            Cone,
            Cube,
            Cylinder,
            Dodecahedron,
            Icosagedron,
            Octahedron,
            RhombicDodecahedron,
            Sponge,
            Sphere,
            Teapot,
            Tetrahedron,
            Torus
        };

        public Task6()
        {
            InitializeComponent();
            View3d.InitializeContexts();


        }

        public void Display()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glRotated(-30, 1, 0, 0);
            Gl.glRotated(45, 0, 1, 0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Glu.gluPerspective(45, (float)View3d.Width / (float)View3d.Height, 0.1, 200);
            Gl.glLoadIdentity();
        }

        private void SelectFillPrimitive()
        {
            var currentPrimitive = (Primitives)(this.comboBox1.SelectedIndex + 1);

            switch (currentPrimitive)
            {
                case Primitives.None:
                    return;
                case Primitives.Cone:
                    Glut.glutSolidCone(0.2, 0.75, 16, 8);
                    break;
                case Primitives.Cube:
                    Glut.glutSolidCube(0.75);
                    break;
                case Primitives.Cylinder:
                    Glut.glutSolidCylinder(0.2, 0.75, 16, 16);
                    break;
                case Primitives.Dodecahedron:
                    Gl.glTranslated(3, 2, -3);
                    Glut.glutSolidDodecahedron();
                    break;
                case Primitives.Icosagedron:
                    Glut.glutSolidIcosahedron();
                    break;
                case Primitives.Octahedron:
                    Glut.glutSolidOctahedron();
                    break;
                case Primitives.RhombicDodecahedron:
                    Glut.glutSolidRhombicDodecahedron();
                    break;
                case Primitives.Sponge:
                    Glut.glutSolidSierpinskiSponge(7, new double[] { 0, 0 }, 1);
                    break;
                case Primitives.Sphere:
                    Glut.glutSolidSphere(0.75, 16, 16);
                    break;
                case Primitives.Teapot:
                    Glut.glutSolidTeapot(0.5);
                    break;
                case Primitives.Tetrahedron:
                    Glut.glutSolidTetrahedron();
                    break;
                case Primitives.Torus:
                    Glut.glutSolidTorus(0.15, 0.65, 16, 16);
                    break;
            }
        }

        private void SelectWirePrimivite()
        {
            var currentPrimitive = (Primitives)(this.comboBox1.SelectedIndex + 1);

            switch (currentPrimitive)
            {
                case Primitives.None:
                    return;
                case Primitives.Cone:
                    Glut.glutWireCone(0.2, 0.75, 16, 8);
                    break;
                case Primitives.Cube:
                    Glut.glutWireCube(0.75);
                    break;
                case Primitives.Cylinder:
                    Glut.glutWireCube(0.75);
                    break;
                case Primitives.Dodecahedron:
                    Gl.glTranslated(3, 2, -3);
                    Glut.glutWireDodecahedron();
                    break;
                case Primitives.Icosagedron:
                    Glut.glutWireIcosahedron();
                    break;
                case Primitives.Octahedron:
                    Glut.glutWireOctahedron();
                    break;
                case Primitives.RhombicDodecahedron:
                    Glut.glutWireRhombicDodecahedron();
                    break;
                case Primitives.Sponge:
                    Glut.glutWireSierpinskiSponge(7, new double[] { 0, 0, 0 }, 1);
                    break;
                case Primitives.Sphere:
                    Glut.glutWireSphere(0.75, 16, 16);
                    break;
                case Primitives.Teapot:
                    Glut.glutWireTeapot(0.5);
                    break;
                case Primitives.Tetrahedron:
                    Glut.glutWireTetrahedron();
                    break;
                case Primitives.Torus:
                    Glut.glutWireTorus(0.15, 0.65, 16, 16);
                    break;
            }
        }

        private void ShowView_Click(object sender, EventArgs e)
        {
            Display();
            Gl.glViewport(0, 0, View3d.Width, View3d.Height);
            var random = new Random();

            Gl.glColor3d(random.NextDouble(), random.NextDouble(), random.NextDouble());
            Gl.glPushMatrix();

            SelectWirePrimivite();

            Gl.glPopMatrix();
            Gl.glFlush();
            View3d.Invalidate();
        }

        private void ShowFill_Click(object sender, EventArgs e)
        {
            Display();

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            string path = @"C:\Users\Yrulewet\source\repos\LearcnCS\GraphicsLearn\GraphicsLearn\Task_6\Textures\test.jpg";

            int index;
            uint mGlTextureObject = 0;

            
            Il.ilGenImages(1, out index);
            Il.ilBindImage(index);

            bool suc = Il.ilLoadImage(path);

            if (suc)
            {
                int width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
                int height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);
                // Число бит на пиксель
                int bitspp = Il.ilGetInteger(Il.IL_IMAGE_BITS_PER_PIXEL);
                switch (bitspp)
                {
                    // Создаем текстуру, используя GL_RGB или GL_RGBA
                    case 24:
                        mGlTextureObject = MakeGlTexture(Gl.GL_RGB, Il.ilGetData(), width, height); break;
                    case 32:
                        mGlTextureObject = MakeGlTexture(Gl.GL_RGBA, Il.ilGetData(), width, height); break;
                }
                Il.ilDeleteImage(index);
            }

            Gl.glEnable(Gl.GL_TEXTURE_GEN_S);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_T);

            Gl.glTexGeni(Gl.GL_S, Gl.GL_TEXTURE_GEN_MODE, Gl.GL_OBJECT_LINEAR);
            Gl.glTexGeni(Gl.GL_T, Gl.GL_TEXTURE_GEN_MODE, Gl.GL_OBJECT_LINEAR);
            
            SelectFillPrimitive();
            Gl.glDisable(Gl.GL_TEXTURE_GEN_S);
            Gl.glDisable(Gl.GL_TEXTURE_GEN_T);
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glDeleteTextures(1, ref mGlTextureObject);

            View3d.Invalidate();
        }
        private uint MakeGlTexture(int Format, IntPtr pixels, int w, int h)
        {
            // Идентификатор текстуры
            uint texObject;
            // Генерируем под номером 1 текстуру
            Gl.glGenTextures(1, out texObject);
            // Выполняем привязка OpenGL к созданной текстуре
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texObject);
            // Режимы фильтрации текстуры
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            // Замещаем существующую заливку
            Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE);
            // Создаем RGB или RGBA текстуру (в зависимости от значения параметра Format)
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Format, w, h, 0, Format, Gl.GL_UNSIGNED_BYTE, pixels);
            // Возвращаем идентификатор текстуры
            return texObject;
        }

        private void View3d_Load(object sender, EventArgs e)
        {
            Gl.glClearColor(255, 255, 255, 1);
            Il.ilInit();
            Il.ilEnable(Il.IL_ORIGIN_SET);

            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            
        }
    }

}
