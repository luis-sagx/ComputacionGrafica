using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Square : Shape
    {
        private float mSide;
        public Square() : base()
        {
            mSide = 0.0f;
        }
        public override void ReadData(params TextBox[] inputs)
        {
            try
            {
                mSide = float.Parse(inputs[0].Text);
                isValid = true;
                if (mSide <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mSide > 17) {
                    MessageBox.Show("The number is very big.\nEnter a number less that 17", "Error Message");
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
            mArea = isValid ? mSide * mSide : 0;
        }

        public override void CalculatePerimeter()
        {
            mPerimeter = isValid ? 4 * mSide : 0;
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            mSide = 0.0f;
            txtSide.Text = "";
        }
        public override void PlotShape(PictureBox picCanvas)
        {
            if (!isValid) return;
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Peru, 3);
            mGraph.DrawRectangle(mPen, picCanvas.Width/2 - mSide/2 * SF, picCanvas.Height / 2 - mSide / 2 * SF, mSide * SF, mSide * SF);
        }
    }
}
