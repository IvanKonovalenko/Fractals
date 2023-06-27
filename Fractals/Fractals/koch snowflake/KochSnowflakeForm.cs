using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Fractals.Fractals.koch_snowflake
{
    public partial class KochSnowflakeForm : Form
    {
        static Pen pen1;
        static Graphics g;
        static Pen pen2;

        int WIDTH;
        int HEIGHT;
        int PXL;
        public KochSnowflakeForm(int width, int height, int pxl)
        {
            WIDTH = width;
            HEIGHT = height;
            PXL = pxl;
            InitializeComponent();
            pictureBox1.Width = width;
            pictureBox1.Height = height;
        }
        private Color getcolor(int num) => num switch
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
        private void KochSnowflakeForm_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int ran = random.Next(1, 7);
            Bitmap bitmap = new Bitmap(WIDTH, HEIGHT);
            this.Width = WIDTH;
            this.Height = HEIGHT;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //Выбираем цвета зарисовки 
            pen1 = new Pen(getcolor(ran), 1);
            pen2 = new Pen(getcolor(ran), 1);
            //Определяем объект "g" класса Graphics
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.Black);

            //Определим координаты исходного треугольника
            var point1 = new PointF(WIDTH / 7 * 2, HEIGHT / 8 * 2);
            var point2 = new PointF(WIDTH / 7 * 5, HEIGHT / 8 * 2);
            var point3 = new PointF(WIDTH / 2, HEIGHT / 8 * 6);

            //Зарисуем треугольник
            g.DrawLine(pen1, point1, point2);
            g.DrawLine(pen1, point2, point3);
            g.DrawLine(pen1, point3, point1);

            //Вызываем функцию Fractal для того, чтобы
            //нарисовать три кривых Коха на сторонах треугольника
            Fractal(point1, point2, point3, PXL);
            Fractal(point2, point3, point1, PXL);
            Fractal(point3, point1, point2, PXL);
            pictureBox1.Image = bitmap;
        }
        static int Fractal(PointF p1, PointF p2, PointF p3, int iter)
        {
            //n -количество итераций
            if (iter > 0)  //условие выхода из рекурсии
            {
                //средняя треть отрезка
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                //координаты вершины угла
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                //рисуем его
                g.DrawLine(pen1, p4, pn);
                g.DrawLine(pen1, p5, pn);
                g.DrawLine(pen2, p4, p5);


                //рекурсивно вызываем функцию нужное число раз
                Fractal(p4, pn, p5, iter - 1);
                Fractal(pn, p5, p4, iter - 1);
                Fractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), iter - 1);
                Fractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), iter - 1);

            }
            return iter;
        }

    }
}