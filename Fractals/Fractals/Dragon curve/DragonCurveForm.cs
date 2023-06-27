using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals.Fractals.Minkowski_sausage
{
    public partial class DragonCurveForm : Form
    {
        int WIDTH;
        int HEIGHT;
        int X0;
        int Y0;
        int PXL;
        public DragonCurveForm(int width, int height, int pxl)
        {
            WIDTH = width;
            HEIGHT = height;
            X0 = width / 2;
            Y0 = height / 2;
            PXL = pxl;
            InitializeComponent();
            pictureBox1.Width = width;
            pictureBox1.Height = height;

        }

        private void DragonCurveForm_Load(object sender, EventArgs e)
        {
            this.Width = WIDTH; this.Height = HEIGHT;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            void dragon_func(int x1, int y1, int x2, int y2, int n, Bitmap bmp, int phaze = 1)
            {

                int xn, yn;
                var drawingPen = new Pen(Brushes.Red, 1);
                switch (phaze)
                {
                    case 1:
                        drawingPen = new Pen(Brushes.Red, 1);
                        break;
                    case 2:
                        drawingPen = new Pen(Brushes.Lime, 1);
                        break;
                    case 3:
                        drawingPen = new Pen(Brushes.Blue, 1);
                        break;
                    case 4:
                        drawingPen = new Pen(Brushes.Yellow, 1);
                        break;
                    case 5:
                        drawingPen = new Pen(Brushes.Purple, 1);
                        break;
                    default:
                        drawingPen = new Pen(Brushes.Aquamarine, 1);
                        phaze = 0;
                        break;
                }

                if (n > 0)
                {
                    xn = ((x1 + x2) / 2 + (y2 - y1) / 2);
                    yn = ((y1 + y2) / 2 - (x2 - x1) / 2);

                    dragon_func(x2, y2, xn, yn, n - 1, bmp, phaze++);
                    dragon_func(x1, y1, xn, yn, n - 1, bmp, phaze++);
                }
                using (Graphics g = Graphics.FromImage(bmp))
                {

                    var point1 = new Point(x1, y1);
                    var point2 = new Point(x2, y2);
                    g.DrawLine(drawingPen, point1, point2);
                }

            }


            int x1, y1, x2, y2, k;

            x1 = X0 - X0 / 3;
            y1 = Y0 - Y0 / 3;
            x2 = WIDTH / 2 + WIDTH / 10;
            y2 = HEIGHT / 2 + HEIGHT / 5;
            k = PXL;
            Bitmap bmp = new Bitmap(WIDTH, HEIGHT);
            dragon_func(x1, y1, x2, y2, k, bmp);
            pictureBox1.Image = bmp;

        }
    }
}