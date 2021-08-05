using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Problema_59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PointF A, B, C, D;
        private Graphics grp;
        private Bitmap bmp;

        private void ReadPoints()
        {
            using (StreamReader reader = new StreamReader(@"../../date.in"))
            {
                string[] tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                A = new PointF(float.Parse(tokens[0]), float.Parse(tokens[1]));
                B = new PointF(float.Parse(tokens[2]), float.Parse(tokens[3]));

                tokens = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                C = new PointF(float.Parse(tokens[0]), float.Parse(tokens[1]));
                D = new PointF(float.Parse(tokens[2]), float.Parse(tokens[3]));
            }
        }

        public float Panta(PointF A, PointF B)
        {
            return (B.Y - A.Y) / (B.X - A.X);
        }

        public int Sign(float f)
        {
            if (f < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            ReadPoints();

            grp.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
            PointF intersection = DrawIntersection(A, B, C, D);

            PointF point1 = new PointF();
            float AB = Panta(A, B);
            point1.X = 1000 * Sign(AB);
            point1.Y = AB * point1.X - AB * A.X + A.Y;
            PointF p2 = new PointF();
            p2.X = 1000 * Sign(AB);
            p2.Y = AB * p2.X - AB * A.X + A.Y;

            grp.DrawLine(new Pen(Color.Black, 5), A, intersection);

            point1 = new PointF();
            float CD = Panta(C, D);
            point1.X = 1000;
            point1.Y = CD * point1.X - CD * C.X + C.Y;

            p2.X = 1000 * Sign(CD);
            p2.Y = CD * p2.X - CD * C.X + C.Y;
            grp.DrawLine(new Pen(Color.Black, 5), C, intersection);

            grp.FillEllipse(new SolidBrush(Color.Red), intersection.X, intersection.Y, 10, 10);
            pictureBox.Image = bmp;
        }

        public PointF DrawIntersection(PointF A, PointF B, PointF C, PointF D)
        {
            float a = A.X - D.X;
            float b = A.Y - D.Y;
            float c = C.X - B.X;
            float d = C.Y - B.Y;
            
            float t1 = b * D.X - a * D.Y;
            float t2 = d * B.X - c * B.Y;

            float det = -b * c + d * a;
            if (det == 0)
            {
                throw new Exception();
            }

            float dx = -t1 * c + t2 * a;
            float dy = b * t2 - d * t1;
            
            float x = dx / det;
            float y = dy / det;
            
            return new PointF(x, y);
        }
    }
}