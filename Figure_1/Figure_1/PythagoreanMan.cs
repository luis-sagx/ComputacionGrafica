using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_1
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class PythagoreanMan
    {
        private float mRadius;
        private float mDiameter;
        private float mCircumference;
        private Graphics mGraph;
        private const float SF = 20.0f; 
        private Pen mPenCircle;
        private Pen mPenPentagon;
        private Pen mPenPentagram;
        private Pen mPenInternal;

        public PythagoreanMan()
        {
            mRadius = mDiameter = mCircumference = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Invalid inputs", "Error Message");
            }
        }

        public void CalculateDiameter()
        {
            mDiameter = 2 * mRadius;
        }

        public void CalculateCircumference()
        {
            mCircumference = (float)(2 * Math.PI * mRadius);
        }


        public void InitializeData(TextBox txtRadius, PictureBox picCanvas)
        {
            mRadius = mDiameter = mCircumference = 0.0f;
            txtRadius.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            //mGraph.SmoothingMode = SmoothingMode.AntiAlias;

            mPenCircle = new Pen(Color.Black, 3);      // Círculo exterior
            mPenPentagon = new Pen(Color.Blue, 2);     // Pentágono
            mPenPentagram = new Pen(Color.Red, 2);     // Pentagrama exterior
            mPenInternal = new Pen(Color.Green, 1);    // Elementos internos

            // Centro del canvas
            float centerX = picCanvas.Width / 2f;
            float centerY = picCanvas.Height / 2f;
            float scaledRadius = mRadius * SF;

            DrawCircle(centerX, centerY, scaledRadius);

            PointF[] pentagonPoints = CalculatePentagonPoints(centerX, centerY, scaledRadius);
            DrawPentagon(pentagonPoints);

            DrawStar(pentagonPoints);

            PointF[] internalPoints = CalculateInternalPoints(pentagonPoints);
            DrawInternalPentagram(internalPoints);
        }

        private void DrawCircle(float centerX, float centerY, float radius)
        {
            mGraph.DrawEllipse(mPenCircle, centerX - radius, centerY - radius, radius * 2, radius * 2);
        }

        private PointF[] CalculatePentagonPoints(float centerX, float centerY, float radius)
        {
            PointF[] points = new PointF[5];
            double startAngle = -Math.PI / 2; // Empezar desde arriba

            for (int i = 0; i < 5; i++)
            {
                double angle = startAngle + (i * 2 * Math.PI / 5);
                points[i] = new PointF(
                    centerX + (float)(radius * Math.Cos(angle)),
                    centerY + (float)(radius * Math.Sin(angle))
                );
            }
            return points;
        }

        private void DrawPentagon(PointF[] points)
        {
            mGraph.DrawPolygon(mPenPentagon, points);
        }

        private void DrawStar(PointF[] points)
        {
            for (int i = 0; i < 5; i++)
            {
                int next = (i + 2) % 5;         
                mGraph.DrawLine(mPenPentagram, points[i], points[next]);
            }
        }

        private PointF[] CalculateInternalPoints(PointF[] externalPoints)
        {
            PointF[] internalPoints = new PointF[5];

            for (int i = 0; i < 5; i++)
            {
                PointF p1_start = externalPoints[i];
                PointF p1_end = externalPoints[(i + 2) % 5];

                PointF p2_start = externalPoints[(i + 3) % 5];
                PointF p2_end = externalPoints[(i + 1) % 5];

                internalPoints[i] = CalculateLineIntersection(p1_start, p1_end, p2_start, p2_end);
            }

            return internalPoints;
        }

        private PointF CalculateLineIntersection(PointF p1, PointF p2, PointF p3, PointF p4)
        {
            float t = 2.0f / (1 + (float)Math.Sqrt(5));

            return new PointF(
                p1.X + t * (p2.X - p1.X),
                p1.Y + t * (p2.Y - p1.Y)
            );
        }

        private void DrawInternalPentagram(PointF[] points)
        {
            for (int i = 0; i < 5; i++)
            {
                int next = (i + 2) % 5;
                mGraph.DrawLine(mPenInternal, points[i], points[next]);
            }
        }

        public void CloseForm(Form ObjForm)
        {

            ObjForm.Close();
        }
    }
    
}
