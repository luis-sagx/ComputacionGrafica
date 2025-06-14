using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    //Estrella regular de 5 puntas
    public class Star : Shape
    {
        private float mSide;

        public Star() : base()
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
                else if (mSide > 17)
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
            if (!isValid)
            {
                mArea = 0;
            } 
            else
            {
                mArea = (float)(mSide * mSide * (1 + Math.Sqrt(5)) / 4);
            }
        }

        public override void CalculatePerimeter()
        {
            mPerimeter = isValid ? 5 * mSide : 0;
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            txtSide.Text = "";
            mSide = 0.0f;
        }

        public override void PlotShape(PictureBox canvas)
        {
            if (!isValid) return;

            mGraph = canvas.CreateGraphics();
            mPen = new Pen(Color.Orange, 3);

            float centerX = canvas.Width / 2f;
            float centerY = canvas.Height / 2f;

            float outerRadius = mSide / 2f;
            float innerRadius = outerRadius * 0.382f; // aproximación para estrella regular

            PointF[] points = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                double angleDeg = -90 + i * 36; // empieza en -90°, pasos de 36° (360/10)
                double angleRad = angleDeg * Math.PI / 180;

                float radius = (i % 2 == 0) ? outerRadius : innerRadius;

                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angleRad) * SF,
                    centerY + radius * (float)Math.Sin(angleRad) * SF
                );
            }

            mGraph.DrawPolygon(mPen, points);
        }

    }
}
