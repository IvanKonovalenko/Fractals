using Fractals.Fractals.Newton_fractal;
using Fractals.Fractals.koch_snowflake;
using Fractals.Fractals.Sierpinski_triangle;
using Fractals.Fractals.Minkowski_sausage;
using System.Diagnostics;

namespace Fractals
{
    public partial class MainMenuForm : Form
    {
        NewtonFractalForm _newtonFractalForm;
        KochSnowflakeForm _kochSnowflakeForm;
        SierpinskiTriangleForm _sierpinskiTriangleForm;
        DragonCurveForm _dragonCurveForm;
        Process _pythonFractals;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void NewtonButton_Click(object sender, EventArgs e)
        {
            if (_dragonCurveForm == null || _dragonCurveForm.IsDisposed)
            {
                double Pxl = 0;
                double.TryParse(PXL.Text, out Pxl);
                int Width = 0;
                int.TryParse(WIDTH.Text, out Width);
                int Height = 0;
                int.TryParse(HEIGHT.Text, out Height);
                if (Width < 1 || Height < 1 || Pxl < 0.00000000001) return;
                _newtonFractalForm = new(Width, Height, Pxl);
                _newtonFractalForm.Closed += (s, args) => this.Show();
                this.Hide();
                _newtonFractalForm.Show();
            }
        }
        private void DragonCurveButton_Click_1(object sender, EventArgs e)
        {
            if (_dragonCurveForm == null || _dragonCurveForm.IsDisposed)
            {
                int Pxl = 0;
                int.TryParse(PXL.Text, out Pxl);
                int Width = 0;
                int.TryParse(WIDTH.Text, out Width);
                int Height = 0;
                int.TryParse(HEIGHT.Text, out Height);
                if (Width < 1 || Height < 1 || Pxl < 1 || Pxl > 20) return;
                _dragonCurveForm = new(Width, Height, Pxl);
                _dragonCurveForm.Closed += (s, args) => this.Show();
                this.Hide();
                _dragonCurveForm.Show();
            }
        }

        private void SierpinskiTriangleButton_Click(object sender, EventArgs e)
        {
            if (_sierpinskiTriangleForm == null || _sierpinskiTriangleForm.IsDisposed)
            {
                int Pxl = 0;
                int.TryParse(PXL.Text, out Pxl);
                int Width = 0;
                int.TryParse(WIDTH.Text, out Width);
                int Height = 0;
                int.TryParse(HEIGHT.Text, out Height);
                if (Width < 1 || Height < 1 || Pxl < 0 || Pxl > 14) return;
                _sierpinskiTriangleForm = new(Width, Height, Pxl);
                _sierpinskiTriangleForm.Closed += (s, args) => this.Show();
                this.Hide();
                _sierpinskiTriangleForm.Show();
            }
        }

        private void KochSnowflakeButton_Click(object sender, EventArgs e)
        {
            if (_kochSnowflakeForm == null || _kochSnowflakeForm.IsDisposed)
            {
                int Pxl = 0;
                int.TryParse(PXL.Text, out Pxl);
                int Width = 0;
                int.TryParse(WIDTH.Text, out Width);
                int Height = 0;
                int.TryParse(HEIGHT.Text, out Height);
                if (Width < 1 || Height < 1 || Pxl < 1 || Pxl > 11) return;
                _kochSnowflakeForm = new(Width, Height, Pxl);
                _kochSnowflakeForm.Closed += (s, args) => this.Show();
                this.Hide();
                _kochSnowflakeForm.Show();
            }
        }

        private void PythonfractalsButton_Click(object sender, EventArgs e)
        {
            _pythonFractals= new Process();
            _pythonFractals.StartInfo.FileName = "main.exe";
            this.Hide();
          
            _pythonFractals.Start();
            _pythonFractals.WaitForExit();

            this.Show();
        }
    }
}