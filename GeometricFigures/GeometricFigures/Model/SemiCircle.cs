using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class SemiCircle : Circle
    {
        public override void CalculateArea()
        {
            mArea = isValid ? (float)(Math.PI * Math.Pow(mRadius, 2) / 2) : 0;
        }

        public override void CalculatePerimeter()
        {
            mPerimeter = isValid ? (float)(Math.PI * mRadius + 2 * mRadius) : 0;
        }

        public override void PlotShape(PictureBox picCanvas)
        {
            if (!isValid) return;
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.SkyBlue, 3);
            mGraph.DrawArc(mPen, (picCanvas.Width / 2) - (mRadius * SF), (picCanvas.Height / 2) - (mRadius * SF), 2 * mRadius * SF, 2 * mRadius * SF, 0, 180);
            mGraph.DrawLine(mPen, (picCanvas.Width / 2) - (mRadius * SF), picCanvas.Height / 2, picCanvas.Width / 2 + mRadius * SF, picCanvas.Height / 2);
        }

    }
}
