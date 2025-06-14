using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Elipse : Shape
    {
        private float mA;
        private float mB;

        public Elipse() : base()
        {
            mA = mB = 0.0f;
        }

        public override void ReadData(params TextBox[] inputs)
        {
            try
            {
                mA = float.Parse(inputs[0].Text);
                mB = float.Parse(inputs[1].Text);
                isValid = true;
                if (mA <= 0 || mB <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mA > 9 || mB > 9)
                {
                    MessageBox.Show("The number is very big.\nEnter a number less that 17", "Error Message");
                    isValid = false;
                }
                else if (mA == mB)
                {
                    MessageBox.Show("The values are equal.\nThis is a circle.", "Error Message");
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
            mArea = isValid ? (float)(Math.PI * mA * mB) : 0;
        }

        public override void CalculatePerimeter()
        {
            if (!isValid)
            {
                mPerimeter = 0;
            }
            else
            {
                mPerimeter = (float)(Math.PI * (3 * (mA + mB) - Math.Sqrt((3 * mA + mB) * (mA + 3 * mB))));
            }
        }

        public void InitializeData(TextBox txtA, TextBox txtB, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            txtA.Text = txtB.Text = "";
            mA = mB = 0.0f;
        }

        public override void PlotShape(PictureBox canvas)
        {
            if(!isValid) return;
            mGraph = canvas.CreateGraphics();
            mPen = new Pen(Color.HotPink, 3);
            mGraph.DrawEllipse(mPen, (canvas.Width / 2) - (mA * SF), (canvas.Height / 2) - (mB * SF), mA * SF * 2, mB * SF * 2);
        }
    }
}
