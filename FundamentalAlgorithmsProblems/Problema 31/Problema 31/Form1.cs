using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalulLuiKoch
{
    public partial class Form1 : Form
    {
        private Pen pen;
        private Graphics graphics;
        private Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(Color.LightBlue);
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            float startX1, startY, startX2;
            PointF startPoint1, startPoint2, startPoint3;

            pictureBox.BackColor = Color.Black;

            startX1 = pictureBox.Width * 1 / 3;
            startX2 = pictureBox.Width * 2 / 3;
            startY = pictureBox.Height * 2 / 3;

            startPoint1 = new PointF(startX1, startY);
            startPoint3 = new PointF(startX2, startY);
            startPoint2 = RotatePoint(startPoint3, startPoint1, 60f);

            graphics.DrawPolygon(pen, new PointF[] { startPoint1, startPoint2, startPoint3 });
            graphics.FillPolygon(new SolidBrush(Color.LightBlue), new PointF[] { startPoint1, startPoint2, startPoint3 });

            Koch(startPoint1, startPoint2, startPoint3);

            pictureBox.Image = bitmap;
        }

        public PointF RotatePoint(PointF firstPoint, PointF secondPoint, float degress)
        {
            double rotationAngle = degress * (Math.PI / 180.0);
            float x = (float)(firstPoint.X + (secondPoint.X - firstPoint.X) * Math.Cos(rotationAngle) - (secondPoint.Y - firstPoint.Y) * Math.Sin(rotationAngle));
            float y = (float)(firstPoint.Y + (secondPoint.X - firstPoint.X) * Math.Sin(rotationAngle) + (secondPoint.Y - firstPoint.Y) * Math.Cos(rotationAngle));

            return new PointF(x, y);
        }

        public void Koch(PointF firstPoint, PointF secondPoint, PointF thirdPoint)
        {
            KochCurve(firstPoint, secondPoint, 1);
            KochCurve(firstPoint, thirdPoint, -1);
            KochCurve(secondPoint, thirdPoint, 1);
        }

        public void KochCurve(PointF firstPoint, PointF secondPoint, int sign)
        {
            if (Distance(firstPoint, secondPoint) > 0.1f)
            {
                PointF guidePoint1 = GuidePoint(firstPoint, secondPoint, 0.5f);
                PointF guidePoint2 = GuidePoint(firstPoint, secondPoint, 2);

                PointF rotatedPoint = RotatePoint(guidePoint1, guidePoint2, -60f * sign);

                graphics.DrawLine(pen, guidePoint1, rotatedPoint);
                graphics.DrawLine(pen, guidePoint2, rotatedPoint);
                graphics.DrawLine(pen, guidePoint1, guidePoint2);

                graphics.FillPolygon(new SolidBrush(Color.LightBlue), new PointF[] { guidePoint1, guidePoint2, rotatedPoint });

                KochCurve(firstPoint, guidePoint1, sign);
                KochCurve(guidePoint2, secondPoint, sign);
                KochCurve(guidePoint1, rotatedPoint, sign);
                KochCurve(guidePoint2, rotatedPoint, -sign);
            }
        }

        public double Distance(PointF firstPoint, PointF secondPoint)
        {
            return Math.Sqrt((secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) + (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X));
        }

        public PointF GuidePoint(PointF firstPoint, PointF secondPoint, float teta)
        {
            return new PointF((firstPoint.X + teta * secondPoint.X) / (1 + teta), (firstPoint.Y + teta * secondPoint.Y) / (1 + teta));
        }
    }
}