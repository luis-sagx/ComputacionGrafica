using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Trapezoid : Shape
    {
        public float mMajorBase { get; set; }
        public float mMinorBase { get; set; }
        public float mHeight { get; set; }

        public Trapezoid() : base()
        {
            mMajorBase = mMinorBase = mHeight = 0.0f;
        }

        public override void ReadData(params TextBox[] inputs)
        {
            try {
                mMajorBase = float.Parse(inputs[0].Text);
                mMinorBase = float.Parse(inputs[1].Text);
                mHeight = float.Parse(inputs[2].Text);
                isValid = true;
                if (mMajorBase <= 0 || mMinorBase <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mMajorBase > 17 || mMinorBase > 17 || mHeight > 17)
                {
                    MessageBox.Show("The number is very big.\nEnter a number less that 17", "Error Message");
                    isValid = false;
                }
                else if (mMajorBase <= mMinorBase)
                {
                    MessageBox.Show("The major base must be greater than the minor base.", "Error Message");
                    isValid = false;
                }
            } 
            catch {
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
            else
            {
                mArea = ((mMajorBase + mMinorBase) / 2) * mHeight;
            }
        }
        public override void CalculatePerimeter()
        {
            if (!isValid)
            {
                mPerimeter = 0;
            }
            else
            {
                mPerimeter = mMajorBase + mMinorBase + 2 * (float)Math.Sqrt((mHeight * mHeight) + ((mMajorBase - mMinorBase) * (mMajorBase - mMinorBase)) / 4);
            }
        }
        public void InitializeData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            txtMajorBase.Text = txtMinorBase.Text = txtHeight.Text = "";
            mMajorBase = mMinorBase = mHeight = 0.0f;
            
        }
        public override void PlotShape(PictureBox canvas)
        {
            if (!isValid) return;
            mGraph = canvas.CreateGraphics();
            mPen = new Pen(Color.DarkSlateBlue, 3);
            PointF[] points = new PointF[4];
            points[0] = new PointF((canvas.Width / 2) - (mMajorBase * SF / 2), (canvas.Height / 2) + (mHeight * SF / 2));
            points[1] = new PointF((canvas.Width / 2) + (mMajorBase * SF / 2), (canvas.Height / 2) + (mHeight * SF / 2));
            points[2] = new PointF((canvas.Width / 2) + (mMinorBase * SF / 2), (canvas.Height / 2) - (mHeight * SF / 2));
            points[3] = new PointF((canvas.Width / 2) - (mMinorBase * SF / 2), (canvas.Height / 2) - (mHeight * SF / 2));
            mGraph.DrawPolygon(mPen, points);
        }
    }
}
