using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Problema_60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        private Bitmap bitmap;
        private PointF[] pointArray;
        private int lenght;
        private Pen pen = new Pen(Color.Black);

        private void ReadPoints(float v)
        {
            using (StreamReader reader = new StreamReader(@"../../date.in"))
            {
                string text = reader.ReadToEnd();
                string[] tokens = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                pointArray = new PointF[tokens.Length];

                for (int i = 0; i < tokens.Length; i++)
                {
                    string[] pointTokens = tokens[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    float x = float.Parse(pointTokens[0]);
                    float y = float.Parse(pointTokens[1]);
                    pointArray[i] = new PointF(x * v, y * v);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            ReadPoints(4.5f);

            lenght = pointArray.Length;
            Poligon(pointArray);

            pictureBox.Image = bitmap;
        }

        public PointF Midle(PointF A, PointF B)
        {
            float newX = (A.X + B.X) / 2;
            float newY = (A.Y + B.Y) / 2;

            return new PointF(newX, newY);
        }

        public float SqDist(PointF A, PointF B)
        {
            return (B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y);
        }

        public void Poligon(PointF[] pointArr)
        {
            if (SqDist(pointArr[0], pointArr[lenght - 1]) == 0)
            {
                return;
            }
            else
            {
                graphics.DrawPolygon(pen, pointArr);
                PointF[] newArray = new PointF[lenght];
                for (int i = 0; i < lenght - 1; i++)
                {
                    newArray[i] = Midle(pointArr[i], pointArr[i + 1]);
                }

                newArray[lenght - 1] = Midle(pointArr[0], pointArr[lenght - 1]);
                Poligon(newArray);
            }
        }
    }
}