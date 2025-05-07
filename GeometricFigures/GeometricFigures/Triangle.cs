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
            int picHeight = (int)((2*mArea)/mSideC);
            int centerX = (int)(picCanvas.Width / 2 - mSideC / 2 * SF);
            int centerY = picCanvas.Height / 2 - picHeight / 2;

            Point[] points = new Point[]
            {
                new Point(centerX, centerY),
                new Point(centerX + (int)(mSideC * SF), centerY), 
                new Point(centerX + (int)(cx * SF), centerY - (int)(cy * SF)) 
            };
            mGraph.DrawPolygon(mPen, points);
        }

        
    }
}
