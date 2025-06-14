using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace Examen_Sagnay_Luis
{
    public class Estrellas
    {
        private float mSide;
        private Graphics mGraph;
        private float SF = 20;
        private int mLados = 8;

        private float mRotationAngle = 0.0f;
        private float mTranslateX = 0.0f;
        private float mTranslateY = 0.0f;

        public Estrellas()
        {
            mSide = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                if (mSide > 10 || mSide < 0) {
                    MessageBox.Show("Invalid input", "Error");
                    mSide = 0;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input", "Error");
            }
        }

        public void InitializeData(TextBox txtSide, PictureBox picCanvas)
        {
            mSide = 0.0f;
            mRotationAngle = 0.0f;
            mTranslateX = 0.0f;
            mTranslateY = 0.0f;
            txtSide.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            float scaledSide = mSide * SF;

            float canvasCenterX = picCanvas.Width / 2f;
            float canvasCenterY = picCanvas.Height / 2f;

            float radiusOuter = scaledSide / (2 * (float)Math.Sin(Math.PI / mLados));
            float radiusInner = radiusOuter * 0.45f;

            Pen blackPen = new Pen(Color.Black, 3);
            Pen bluePen = new Pen(Color.Blue, 2);

            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(picCanvas.BackColor);

            PointF[] polygon = TransformPoints(GetPolygonPoints(mLados, radiusOuter, 0, 0, -Math.PI / 2), canvasCenterX, canvasCenterY);
            mGraph.DrawPolygon(blackPen, polygon);

            PointF[] estrella1 = TransformPoints(GetStarPoints(mLados, radiusOuter, radiusInner, 0, 0, -Math.PI / 2), canvasCenterX, canvasCenterY);
            mGraph.DrawPolygon(bluePen, estrella1);
            for (int i = 1; i < estrella1.Length; i += 2)
                mGraph.DrawLine(bluePen, canvasCenterX + mTranslateX, canvasCenterY + mTranslateY, estrella1[i].X, estrella1[i].Y);

            PointF[] estrella2 = TransformPoints(GetStarPoints(mLados, radiusOuter * 0.9f, radiusInner * 0.9f, 0, 0, Math.PI / 8), canvasCenterX, canvasCenterY);
            mGraph.DrawPolygon(bluePen, estrella2);
            for (int i = 1; i < estrella2.Length; i += 2)
                mGraph.DrawLine(bluePen, canvasCenterX + mTranslateX, canvasCenterY + mTranslateY, estrella2[i].X, estrella2[i].Y);
        }

        private PointF[] TransformPoints(PointF[] points, float centerX, float centerY)
        {
            PointF[] transformed = new PointF[points.Length];

            for (int i = 0; i < points.Length; i++)
            {
                float dx = points[i].X;
                float dy = points[i].Y;

                float xRot = dx * (float)Math.Cos(mRotationAngle) - dy * (float)Math.Sin(mRotationAngle);
                float yRot = dx * (float)Math.Sin(mRotationAngle) + dy * (float)Math.Cos(mRotationAngle);

                transformed[i] = new PointF(centerX + xRot + mTranslateX, centerY + yRot + mTranslateY);
            }

            return transformed;
        }

        private PointF[] GetStarPoints(int lados, float outer, float inner, float cx, float cy, double offset)
        {
            PointF[] points = new PointF[2 * lados];
            double angleStep = Math.PI / lados;
            double angle = offset;

            for (int i = 0; i < 2 * lados; i++)
            {
                float radius = (i % 2 == 0) ? outer : inner;
                float x = cx + (float)(radius * Math.Cos(angle));
                float y = cy + (float)(radius * Math.Sin(angle));
                points[i] = new PointF(x, y);
                angle += angleStep;
            }

            return points;
        }

        private PointF[] GetPolygonPoints(int lados, float radius, float cx, float cy, double offset)
        {
            PointF[] points = new PointF[lados];
            double angleStep = 2 * Math.PI / lados;
            double angle = offset;

            for (int i = 0; i < lados; i++)
            {
                float x = cx + (float)(radius * Math.Cos(angle));
                float y = cy + (float)(radius * Math.Sin(angle));
                points[i] = new PointF(x, y);
                angle += angleStep;
            }

            return points;
        }

        public void RotateLeft(PictureBox picCanvas)
        {
            mRotationAngle -= (float)(Math.PI / 45);
            PlotShape(picCanvas);
        }

        public void RotateRight(PictureBox picCanvas)
        {
            mRotationAngle += (float)(Math.PI / 45);
            PlotShape(picCanvas);
        }


        public void ZoomIn(PictureBox picCanvas)
        {
            SF *= 1.1f;
            PlotShape(picCanvas);
        }

        public void ZoomOut(PictureBox picCanvas)
        {
            SF *= 0.9f;
            PlotShape(picCanvas);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }


}
