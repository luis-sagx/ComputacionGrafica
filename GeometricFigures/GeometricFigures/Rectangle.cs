using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Rectangle : Shape
    {
        public float mWidth { get; set; }
        public float mHeight { get; set; }

        public Rectangle() : base()
        {
            mWidth = mHeight = 0.0f;
        }

        public override void ReadData(params TextBox[] inputs)
        {
            try
            {
                mWidth = float.Parse(inputs[0].Text);
                mHeight = float.Parse(inputs[1].Text);
                isValid = true;
                if (mWidth <= 0 || mHeight <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mWidth > 17 || mHeight > 17)
                {
                    MessageBox.Show("The number is very big.\nEnter a number less that 17", "Error Message");
                    isValid = false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input.\nPlease enter valid values.", "Error Message");
            }
        }

        public override void CalculateArea()
        {
            mArea = isValid ? mWidth * mHeight : 0;
        }

        public override void CalculatePerimeter()
        {
            if (mHeight > 0 && mHeight < 17)
                mPerimeter = isValid ? 2 * (mWidth + mHeight) : 0;
            else
                mPerimeter = 0;
        }

        public void InitializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            mHeight = mWidth = 0.0f;
            txtHeight.Text = txtWidth.Text = "";
        }

        public override void PlotShape(PictureBox picCanvas)
        {
            if (!isValid) return;
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, picCanvas.Width / 2 - mWidth / 2 * SF, picCanvas.Height / 2 - mHeight / 2 * SF, mWidth * SF, mHeight * SF);
        }
    }

}
