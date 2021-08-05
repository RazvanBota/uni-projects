using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalulLuiCantor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        private Bitmap bitmap;
        private PointF startPoint, lastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void ButtonDesenare_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox.BackColor);
            float length = int.Parse(textBoxLinitial.Text);

            startPoint = new PointF(25, 25);
            lastPoint = new PointF(startPoint.X + length, 25);

            Cantor(startPoint, lastPoint, length, 50);
        }

        private void Cantor(PointF firstPoint, PointF secondPoint, float length, int gap)
        {
            if (length < 1)
            {
                return;
            }

            graphics.DrawLine(new Pen(Color.Red, 5), firstPoint, secondPoint);
            pictureBox.Image = bitmap;

            Cantor(new PointF(firstPoint.X, firstPoint.Y + gap), new PointF(firstPoint.X + length / 3, firstPoint.Y + gap), length / 3, gap);
            Cantor(new PointF(secondPoint.X - length / 3, secondPoint.Y + gap), new PointF(secondPoint.X, secondPoint.Y + gap), length / 3, gap);
        }
    }
}