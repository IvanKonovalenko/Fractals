using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals.Fractals.Sierpinski_triangle
{
    public partial class SierpinskiTriangleForm : Form
    {
        Random random = new Random();
        int WIDTH;
        int HEIGHT;
        int PXL;
        public SierpinskiTriangleForm(int width, int height, int pxl)
        {
            WIDTH = width;
            HEIGHT = height;
            PXL = pxl;
            InitializeComponent();
            pictureBox1.Width = width;
            pictureBox1.Height = height;
        }

        private void SierpinskiTriangleForm_Load(object sender, EventArgs e)
        {
            this.Width = WIDTH; this.Height = HEIGHT;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Bitmap bitmap = new Bitmap(WIDTH,HEIGHT);
            Graphics g = Graphics.FromImage(bitmap);
            GenerateTriangle(g, PXL, 0, HEIGHT, WIDTH / 2, 0, WIDTH, HEIGHT,Color.MediumVioletRed);
            pictureBox1.Image = bitmap;
        }
        public void GenerateTriangle(Graphics g, int iIterations, double x1, double y1, double x2, double y2, double x3, double y3, Color oColor)
        {
            Color getcolor(int num) => num switch
            {
                1 => Color.Red,
                2 => Color.Orange,
                3 => Color.Yellow,
                4 => Color.Green,
                5 => Color.LightBlue,
                6 => Color.Blue,
                7 => Color.Purple,
                _ => Color.Black,
            };
   
            if (iIterations>0)
	        {
                double midx1 = (x1 + x2) / 2;
                double midy1 = (y1 + y2) / 2;
                double midx2 = (x2 + x3) / 2;
                double midy2 = (y2 + y3) / 2;
                double midx3 = (x3 + x1) / 2;
                double midy3 = (y3 + y1) / 2;
                GenerateTriangle(g, iIterations - 1, x1, y1, midx1, midy1, midx3, midy3, oColor);
                GenerateTriangle(g, iIterations - 1, midx1, midy1, x2, y2, midx2, midy2, oColor);
                GenerateTriangle(g, iIterations - 1, midx3, midy3, midx2, midy2, x3, y3, oColor);
            }
            else
            {
                PointF[] points = new PointF[3];
                points[0] = new PointF((float)x1, (float)y1);
                points[1] = new PointF((float)x2, (float)y2);
                points[2] = new PointF((float)x3, (float)y3);
                int randomcolor = random.Next(1, 7);
                oColor=getcolor(randomcolor);
                g.FillPolygon(new SolidBrush(oColor), points);
            }
        }
    }
}
