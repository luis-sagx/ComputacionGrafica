using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Rhombus : Shape
    {
        private float mMajorDiagonal;
        private float mMinorDiagonal;

        public Rhombus() : base() { 
            mMajorDiagonal = 0.0f;
            mMinorDiagonal = 0.0f;
        }
        public override void ReadData(params TextBox[] inputs)
        {
            try { 
                mMajorDiagonal = float.Parse(inputs[0].Text);
                mMinorDiagonal = float.Parse(inputs[1].Text);
                isValid = true;
                if (mMajorDiagonal <= 0 || mMinorDiagonal <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mMajorDiagonal < mMinorDiagonal)
                {
                    MessageBox.Show("The major diagonal must be greater than the minor diagonal.", "Error Message");
                    isValid = false;
                }
                else if (mMajorDiagonal > 17 || mMinorDiagonal > 17) {
                    MessageBox.Show("The number is very big.\nEnter a number less that 17", "Error Message");
                    isValid = false;
                }
            } catch { }
        }
        public override void CalculateArea()
        {
            mArea = isValid ? (mMajorDiagonal * mMinorDiagonal) / 2 : 0;
        }

        public float CalcularLadoRombo(float D, float d)
        {
            return (float)Math.Sqrt(Math.Pow(D / 2, 2) + Math.Pow(d / 2, 2));
        }

        public override void CalculatePerimeter()
        {
            if (isValid)
            {
                float lado = CalcularLadoRombo(mMajorDiagonal, mMinorDiagonal);
                mPerimeter = 4 * lado;
            }
            else
            {
                mPerimeter = 0;
            }
        }

        public void InitializeData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            txtMajorBase.Text = txtMinorBase.Text = "";
            mMajorDiagonal = mMinorDiagonal = 0.0f;

        }

        public override void PlotShape(PictureBox picCanvas)
        {
            if (!isValid) return;
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Magenta, 3);
            PointF[] points = new PointF[4];
            points[0] = new PointF(picCanvas.Width / 2, picCanvas.Height / 2 - mMinorDiagonal / 2 * SF);
            points[1] = new PointF(picCanvas.Width / 2 + mMajorDiagonal / 2 * SF, picCanvas.Height / 2);
            points[2] = new PointF(picCanvas.Width / 2, picCanvas.Height / 2 + mMinorDiagonal / 2 * SF);
            points[3] = new PointF(picCanvas.Width / 2 - mMajorDiagonal / 2 * SF, picCanvas.Height / 2);
            mGraph.DrawPolygon(mPen, points);
        }

    }
}
