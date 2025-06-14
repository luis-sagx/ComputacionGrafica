using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Trapezoide : Trapezoid
    {
        private float mSideA;
        private float mSideB;

        public Trapezoide() : base()
        {
            mSideA = mSideB = 0.0f;
        }
        public override void ReadData(params TextBox[] inputs)
        {
            base.ReadData(inputs[0], inputs[1], inputs[2]);
            try
            {
                mSideA = float.Parse(inputs[3].Text);
                mSideB = float.Parse(inputs[4].Text);
                isValid = true;
                if (mSideA <= 0 || mSideB <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mSideA > 17 || mSideB > 17)
                {
                    MessageBox.Show("The number is very big.\nEnter a number less that 17", "Error Message");
                    isValid = false;
                }
                else if (mSideA >= mMajorBase || mSideB >= mMajorBase)
                {
                    MessageBox.Show("The side must be less than the base.", "Error Message");
                    isValid = false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input.\nPlease enter valid values.", "Error Message");
                isValid = false;
            }
        }

        public override void CalculatePerimeter()
        {
            mPerimeter = isValid ? mMajorBase + mMinorBase + mSideA + mSideB : 0;
        }

        public void InitializeData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtHeight, TextBox txtSideA, TextBox txtSideB, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtMajorBase, txtMinorBase, txtHeight, txtPerimeter, txtArea, picCanvas);
            txtSideA.Text = txtSideB.Text = "";
            mSideA = mSideB = 0.0f;
        }

        public override void PlotShape(PictureBox canvas)
        {
            mGraph = canvas.CreateGraphics();
            mPen = new Pen(Color.OrangeRed, 3);
            PointF[] points = new PointF[4];
            points[0] = new PointF((canvas.Width / 2) - (mMajorBase * SF / 2), (canvas.Height / 2) + (mHeight * SF / 2));
            points[1] = new PointF((canvas.Width / 2) + (mMinorBase * SF / 2), (canvas.Height / 2) + (mHeight * SF / 2));
            points[2] = new PointF((canvas.Width / 2) + (mSideB * SF / 2), (canvas.Height / 2) - (mHeight * SF / 2));
            points[3] = new PointF((canvas.Width / 2) - (mSideA * SF / 2), (canvas.Height / 2) - (mHeight * SF / 2));
            mGraph.DrawPolygon(mPen, points);
        }
    }
}
