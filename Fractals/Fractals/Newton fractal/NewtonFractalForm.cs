using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals.Fractals.Newton_fractal
{
    public partial class NewtonFractalForm : Form
    {
        const double PI5 = 0.628318530717959;
        const double EPS = 0.1;
        int WIDTH;
        int HEIGHT;
        int X0;
        int Y0;
        double PXL;
        public NewtonFractalForm(int width, int height, double pxl)
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
        private void NewtonFractalForm_Load(object sender, EventArgs e)
        {
            this.Width = WIDTH; this.Height = HEIGHT;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            Bitmap bitmap = new(WIDTH, HEIGHT);

            for (int i = 0; i < WIDTH; i++)
            {
                for (int j = 0; j < HEIGHT; j++)
                {
                    double x = (i - X0) * PXL;
                    double y = (j - Y0) * PXL;
                    Complex z = new Complex(x, y);
                    Complex t;
                    do
                    {
                        t = z;
                        z = 0.8 * z + 0.2 * Complex.Pow(z, -4);
                    } while ((z - t).Magnitude >= EPS);
                    Color color = Color.Red;
                    switch ((int)(z.Phase / PI5))
                    {
                        case 0:
                            color = Color.Red;
                            break;
                        case 1:
                        case 2:
                            color = Color.Lime;
                            break;
                        case 3:
                        case 4:
                            color = Color.Blue;
                            break;
                        case -3:
                        case -4:
                            color = Color.Yellow;
                            break;
                        case -1:
                        case -2:
                            color = Color.Purple;
                            break;
                    }
                    bitmap.SetPixel(i, j, color);
                }
            }
            pictureBox1.Image = bitmap;
        }
    }
}


