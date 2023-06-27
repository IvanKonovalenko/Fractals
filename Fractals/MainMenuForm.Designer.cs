namespace Fractals
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NewtonButton = new Button();
            DragonCurveButton = new Button();
            SierpinskiTriangleButton = new Button();
            KochSnowflakeButton = new Button();
            pictureBox1 = new PictureBox();
            PXL = new TextBox();
            WIDTH = new TextBox();
            HEIGHT = new TextBox();
            PXLLabel = new Label();
            WidthLabel = new Label();
            HeightLabel = new Label();
            PythonfractalsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, -1);
            label1.Name = "label1";
            label1.Size = new Size(205, 31);
            label1.TabIndex = 0;
            label1.Text = "Change fractal";
            // 
            // NewtonButton
            // 
            NewtonButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            NewtonButton.Location = new Point(57, 363);
            NewtonButton.Name = "NewtonButton";
            NewtonButton.Size = new Size(230, 23);
            NewtonButton.TabIndex = 1;
            NewtonButton.Text = "Newton fractal";
            NewtonButton.UseVisualStyleBackColor = true;
            NewtonButton.Click += NewtonButton_Click;
            // 
            // DragonCurveButton
            // 
            DragonCurveButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DragonCurveButton.Location = new Point(57, 392);
            DragonCurveButton.Name = "DragonCurveButton";
            DragonCurveButton.Size = new Size(230, 23);
            DragonCurveButton.TabIndex = 2;
            DragonCurveButton.Text = "Dragon Curve";
            DragonCurveButton.UseVisualStyleBackColor = true;
            DragonCurveButton.Click += DragonCurveButton_Click_1;
            // 
            // SierpinskiTriangleButton
            // 
            SierpinskiTriangleButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SierpinskiTriangleButton.Location = new Point(57, 421);
            SierpinskiTriangleButton.Name = "SierpinskiTriangleButton";
            SierpinskiTriangleButton.Size = new Size(230, 23);
            SierpinskiTriangleButton.TabIndex = 3;
            SierpinskiTriangleButton.Text = "Sierpinski triangle";
            SierpinskiTriangleButton.UseVisualStyleBackColor = true;
            SierpinskiTriangleButton.Click += SierpinskiTriangleButton_Click;
            // 
            // KochSnowflakeButton
            // 
            KochSnowflakeButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            KochSnowflakeButton.Location = new Point(57, 450);
            KochSnowflakeButton.Name = "KochSnowflakeButton";
            KochSnowflakeButton.Size = new Size(230, 23);
            KochSnowflakeButton.TabIndex = 4;
            KochSnowflakeButton.Text = "koch snowflake";
            KochSnowflakeButton.UseVisualStyleBackColor = true;
            KochSnowflakeButton.Click += KochSnowflakeButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2023_06_19_22_33_042;
            pictureBox1.Location = new Point(32, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 270);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // PXL
            // 
            PXL.Location = new Point(103, 506);
            PXL.Name = "PXL";
            PXL.Size = new Size(100, 23);
            PXL.TabIndex = 6;
            // 
            // WIDTH
            // 
            WIDTH.Location = new Point(103, 549);
            WIDTH.Name = "WIDTH";
            WIDTH.Size = new Size(100, 23);
            WIDTH.TabIndex = 7;
            WIDTH.Text = "1920";
            // 
            // HEIGHT
            // 
            HEIGHT.Location = new Point(103, 590);
            HEIGHT.Name = "HEIGHT";
            HEIGHT.Size = new Size(100, 23);
            HEIGHT.TabIndex = 8;
            HEIGHT.Text = "1080";
            // 
            // PXLLabel
            // 
            PXLLabel.AutoSize = true;
            PXLLabel.Location = new Point(103, 488);
            PXLLabel.Name = "PXLLabel";
            PXLLabel.Size = new Size(61, 15);
            PXLLabel.TabIndex = 9;
            PXLLabel.Text = "Parameter";
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(103, 532);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(39, 15);
            WidthLabel.TabIndex = 10;
            WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(103, 575);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(43, 15);
            HeightLabel.TabIndex = 11;
            HeightLabel.Text = "Height";
            // 
            // PythonfractalsButton
            // 
            PythonfractalsButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PythonfractalsButton.Location = new Point(57, 334);
            PythonfractalsButton.Name = "PythonfractalsButton";
            PythonfractalsButton.Size = new Size(230, 23);
            PythonfractalsButton.TabIndex = 12;
            PythonfractalsButton.Text = "Python fractals";
            PythonfractalsButton.UseVisualStyleBackColor = true;
            PythonfractalsButton.Click += PythonfractalsButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 661);
            Controls.Add(PythonfractalsButton);
            Controls.Add(HeightLabel);
            Controls.Add(WidthLabel);
            Controls.Add(PXLLabel);
            Controls.Add(HEIGHT);
            Controls.Add(WIDTH);
            Controls.Add(PXL);
            Controls.Add(pictureBox1);
            Controls.Add(KochSnowflakeButton);
            Controls.Add(SierpinskiTriangleButton);
            Controls.Add(DragonCurveButton);
            Controls.Add(NewtonButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenuForm";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button NewtonButton;
        private Button DragonCurveButton;
        private Button SierpinskiTriangleButton;
        private Button KochSnowflakeButton;
        private PictureBox pictureBox1;
        private TextBox PXL;
        private TextBox WIDTH;
        private TextBox HEIGHT;
        private Label PXLLabel;
        private Label WidthLabel;
        private Label HeightLabel;
        private Button PythonfractalsButton;
    }
}