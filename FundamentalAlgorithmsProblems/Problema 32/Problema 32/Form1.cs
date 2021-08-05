using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriunghiulLuiSierspinski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        Pen p = new Pen(Color.IndianRed, 2);
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            float startX1, startY, startX3;
            startY = pictureBox.Height * 2 / 3;
            startX1 = pictureBox.Width * 1 / 3;
            startX3 = pictureBox.Width - startX1;
            PointF startPoint1, startPoint2, startPoint3;
            startPoint1 = new PointF(startX1, startY);
            startPoint3 = new PointF(startX3, startY);
            startPoint2 = RotirePunct(startPoint3, startPoint1, 60f);
           
            grp.DrawPolygon(p, new PointF[] { startPoint1, startPoint2, startPoint3 });
            grp.FillPolygon(new SolidBrush(p.Color), new PointF[] { startPoint1, startPoint2, startPoint3 });
            Sierspinski(startPoint1, startPoint2, startPoint3);

            pictureBox.Image = bmp;
        }
        public PointF RotirePunct(PointF O, PointF P, float v)
        {
            float newx, newy;
            double angle = v * (Math.PI / 180.0);
            newx = (float)(O.X + (P.X - O.X) * Math.Cos(angle) - (P.Y - O.Y) * Math.Sin(angle));
            newy = (float)(O.Y + (P.X - O.X) * Math.Sin(angle) + (P.Y - O.Y) * Math.Cos(angle));
            return new PointF(newx, newy);
        }
        public double Distance(PointF A, PointF B)
        {
            return Math.Sqrt((B.Y - A.Y) * (B.Y - A.Y) + (B.X - A.X) * (B.X - A.X));
        }
        public PointF PunctRaport(PointF A, PointF B, float teta=1)
        {
            return new PointF((A.X + teta * B.X) / (1 + teta), (A.Y + teta * B.Y) / (1 + teta));

        }
        public void Sierspinski(PointF A,PointF B, PointF C)
        {
            if(Distance(A,B)>=0.1)
            {
                PointF mAB = PunctRaport(A, B);
                PointF mBC = PunctRaport(B, C);
                PointF mAC = PunctRaport(A, C);
                grp.DrawPolygon(p, new PointF[] { mAB, mBC, mAC });
                grp.FillPolygon(new SolidBrush(pictureBox.BackColor), new PointF[] { mAB, mBC, mAC });
                Sierspinski(A, mAC, mAB);
                Sierspinski(mAC, C, mBC);
                Sierspinski(mAB, mBC, B);

            }
        }
    }
}
