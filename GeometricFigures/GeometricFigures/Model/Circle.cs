using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Circle : Shape
    {
        public float mRadius { get; set; }
        public Circle() : base()
        {
            mRadius = 0.0f;
        }

        public override void CalculateArea()
        {
            mArea = isValid ? (float)(Math.PI * mRadius * mRadius) : 0;
        }

        public override void CalculatePerimeter()
        {
            mPerimeter = isValid ? (float)(2 * Math.PI * mRadius) : 0;
        }

        public override void ReadData(params TextBox[] inputs)
        {
            try
            {
                mRadius = float.Parse(inputs[0].Text);
                isValid = true;
                if (mRadius <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mRadius > 9)
                {
                    MessageBox.Show("The number is very big.\nEnter a number less that 9", "Error Message");
                    isValid = false;
                }
            }
            catch
            {
                MessageBox.Show("Invalid input.\nPlease enter valid values.", "Error Message");
                isValid = false;
            }
        }

        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            txtRadius.Text = "";
            mRadius = 0.0f;
        }

        public override void PlotShape(PictureBox canvas)
        {
            if (!isValid) return;
            mGraph = canvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            mGraph.DrawEllipse(mPen, (canvas.Width / 2) - (mRadius * SF), (canvas.Height / 2) - (mRadius * SF), mRadius * SF * 2, mRadius * SF * 2);
        }

    }
}
