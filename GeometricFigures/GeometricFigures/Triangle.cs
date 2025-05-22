using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Triangle : Shape
    { 
        private float mSideA;
        private float mSideB;
        private float mSideC;
        private float s = 0.0f;
        private PointF[] mVertices = new PointF[3];
        private float mRotationAngle = 0;
        private float mTranslateX = 0; 
        private float mTranslateY = 0;
        public Triangle() : base()
        {
            mSideA = mSideB = mSideC = 0.0f;
        }

        public void InitializeData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            txtSideA.Text = txtSideB.Text = txtSideC.Text = "";
            mSideA = mSideB = mSideC = 0.0f;
        }
        public override void ReadData(params TextBox[] inputs)
        {
            try
            {
                mSideA = float.Parse(inputs[0].Text);
                mSideB = float.Parse(inputs[1].Text);
                mSideC = float.Parse(inputs[2].Text);
                isValid = true;
                if (mSideA <= 0 || mSideB <= 0 || mSideC <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mSideA + mSideB <= mSideC || mSideA + mSideC <= mSideB || mSideB + mSideC <= mSideA)
                {
                    MessageBox.Show("Invalid triangle sides.\nThe sum of any two sides must be greater than the third side.", "Error Message");
                    isValid = false;
                }
                else if (mSideA > 17 || mSideB > 17 || mSideC > 17)
                {
                    MessageBox.Show("The number is very big.\nEnter a number less than 17", "Error Message");
                    isValid = false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input.\nPlease enter valid values.", "Error Message");
                isValid = false;
            }
        }
        public override void CalculateArea()
        {
            if (!isValid)
            {
                mArea = 0;
            } 
            else {
                s = (mSideA + mSideB + mSideC) / 2;
                mArea = (float)Math.Sqrt(s * (s - mSideA) * (s - mSideB) * (s - mSideC));
            }
        }

        public override void CalculatePerimeter()
        {
            mPerimeter = isValid ? mSideA + mSideB + mSideC : 0;
        }

        public override void PlotShape(PictureBox picCanvas)
        {
            if (!isValid) return;

            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Turquoise, 3);

            float cosA = (mSideB * mSideB + mSideC * mSideC - mSideA * mSideA) / (2 * mSideB * mSideC);
            float sinA = (float)Math.Sqrt(1 - cosA * cosA);

            float cx = mSideB * cosA;
            float cy = mSideB * sinA;

            PointF[] points = new PointF[]
            {
                new PointF(0, 0),
                new PointF(mSideC * SF, 0),
                new PointF(cx * SF, -cy * SF)
            };

            float centroidX = (points[0].X + points[1].X + points[2].X) / 3;
            float centroidY = (points[0].Y + points[1].Y + points[2].Y) / 3;

            float canvasCenterX = picCanvas.Width / 2f;
            float canvasCenterY = picCanvas.Height / 2f;

            PointF[] finalPoints = new PointF[3];
            for (int i = 0; i < 3; i++)
            {
                float dx = points[i].X - centroidX;
                float dy = points[i].Y - centroidY;

                float xRot = dx * (float)Math.Cos(mRotationAngle) - dy * (float)Math.Sin(mRotationAngle);
                float yRot = dx * (float)Math.Sin(mRotationAngle) + dy * (float)Math.Cos(mRotationAngle);

                finalPoints[i] = new PointF(
                    canvasCenterX + xRot + mTranslateX,
                    canvasCenterY + yRot + mTranslateY
                );
            }

            mGraph.Clear(picCanvas.BackColor);
            mGraph.DrawPolygon(mPen, finalPoints);
        }



        public void RotateLeft(PictureBox picCanvas)
        {
            mRotationAngle -= (float)(Math.PI / 36); 
            PlotShape(picCanvas);
        }

        public void RotateRight(PictureBox picCanvas)
        {
            mRotationAngle += (float)(Math.PI / 36); 
            PlotShape(picCanvas);
        }

        public void MoveUp(PictureBox picCanvas)
        {
            mTranslateY -= 10;
            PlotShape(picCanvas);
        }

        public void MoveDown(PictureBox picCanvas)
        {
            mTranslateY += 10;
            PlotShape(picCanvas);
        }

        public void MoveLeft(PictureBox picCanvas)
        {
            mTranslateX -= 10;
            PlotShape(picCanvas);
        }

        public void MoveRight(PictureBox picCanvas)
        {
            mTranslateX += 10;
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
    }
}
