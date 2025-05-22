using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Figure_1
{
    public class FlorMargarita
    {
        private float mSide;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20; 
        public FlorMargarita()
        {
            mSide = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso invalido...", "Mensaje de error");
            }
        }

        public void InitializeData(TextBox txtSide, PictureBox picCavas)
        {
            mSide  = 0.0f;

            txtSide.Focus();
            picCavas.Refresh();
        }

        private PointF[] GetPentagonPoints(PointF center, float side)
        {
            PointF[] points = new PointF[5];
            float angle = (float)Math.Sin(Math.PI / 5);
            float radius = (float) side / (2 * (float)Math.Sin(Math.PI / 5));

            for (int i = 0; i < 5; i++)
            {
                float x = center.X + radius * (float)Math.Cos(angle);
                float y = center.Y + radius * (float)Math.Sin(angle);
                points[i] = new PointF(x, y);
                angle += (float)(2 * Math.PI / 5);
            }

            return points;
        }

        public void PlotShape(PictureBox picCavas)
        {
            mGraph = picCavas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            float apotema = (float) mSide / (2 * (float)Math.Tan(Math.PI / 5));
            float bigRadius = 2 * apotema;

            float centerX = picCavas.Width / 2;
            float centerY = picCavas.Height / 2;
            PointF center = new PointF(centerX, centerY);

            //PointF[] centralPentagon = GetPentagonPoints(center, mSide);
            //mGraph.DrawPolygon(mPen, centralPentagon);

            for (int i = 0; i < 5; i++)
            {
                float angle = (float)((Math.PI / 5) + i * 2 * Math.PI / 5);
                float x = center.X + bigRadius * (float)Math.Cos(angle);
                float y = center.Y + bigRadius * (float)Math.Sin(angle);
                PointF newCenter = new PointF(x, y);

                PointF[] petalPentagon = GetPentagonPoints(newCenter, mSide);
                mGraph.DrawPolygon(mPen, petalPentagon);
            }
        }
    }
}

    
