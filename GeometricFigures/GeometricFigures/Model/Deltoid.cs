using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Deltoid : Shape 
    {
        private float mMajorDiagonal;
        private float mMinorDiagonal;
        private float mSideA;
        private float mSideB;

        public Deltoid() : base()
        {
            mMajorDiagonal = 0.0f;
            mMinorDiagonal = 0.0f;
            mSideA = 0.0f;
            mSideB = 0.0f;
        }

        public override void ReadData(params TextBox[] inputs)
        {
            try
            {
                mMajorDiagonal = float.Parse(inputs[0].Text);
                mMinorDiagonal = float.Parse(inputs[1].Text);
                mSideA = float.Parse(inputs[2].Text);
                mSideB = float.Parse(inputs[3].Text);
                isValid = true;
                if (mMajorDiagonal <= 0 || mMinorDiagonal <= 0 || mSideA <= 0 || mSideB <= 0)
                {
                    MessageBox.Show("Invalid input.\nEnter a positive value.", "Error Message");
                    isValid = false;
                }
                else if (mMajorDiagonal < mMinorDiagonal)
                {
                    MessageBox.Show("The major diagonal must be greater than the minor diagonal.", "Error Message");
                    isValid = false;
                }
                else if (mMajorDiagonal > 17 || mMinorDiagonal > 17 || mSideA > 17 || mSideB > 17)
                {
                    MessageBox.Show("The number is very big.\nEnter a number less that 17", "Error Message");
                    isValid = false;
                }
                else if (mMajorDiagonal <= mSideA || mMajorDiagonal <= mSideB)
                {
                    MessageBox.Show("The major diagonal must be greater than the Side", "Error Message");
                    isValid = false;
                }
                else if (mMajorDiagonal > (mSideA + mSideB)) {
                    MessageBox.Show("The diagonal is not consistent with the sides", "Error Message");
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
            mArea = isValid ? (mMajorDiagonal * mMinorDiagonal) / 2 : 0;
        }
        public override void CalculatePerimeter()
        {
            mPerimeter = isValid ? 2 * (mSideA + mSideB) : 0;
        }

        public void InitializeData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal, TextBox txtSideA, TextBox txtSideB, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            base.InitializeData(txtPerimeter, txtArea, picCanvas);
            txtMajorDiagonal.Text = txtMinorDiagonal.Text = txtSideA.Text = txtSideB.Text = "";
            mMajorDiagonal = mMinorDiagonal = mSideA = mSideB = 0.0f;
        }

        public override void PlotShape(PictureBox picCanvas)
        {
            if (!isValid) return;

            float cx = picCanvas.Width / 2f;
            float cy = picCanvas.Height / 2f;
            float halfD1 = mMajorDiagonal * SF / 2;
            float halfD2 = mMinorDiagonal * SF / 2;

            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3);

            PointF[] points = new PointF[4];
            points[0] = new PointF(cx, cy - halfD1); // Superior vértice
            points[1] = new PointF(cx + halfD2, cy); // Derecha
            points[2] = new PointF(cx, cy + halfD1); // Inferior vértice
            points[3] = new PointF(cx - halfD2, cy); // Izquierda

            mGraph.DrawPolygon(mPen, points);
        }
    }
}
