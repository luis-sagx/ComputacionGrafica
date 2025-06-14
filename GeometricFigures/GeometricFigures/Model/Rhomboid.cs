using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class Rhomboid : Rectangle
    {
        public Rhomboid() : base() { }

        //Grafico de un romboide teniendo alto y ancho
        public override void PlotShape(PictureBox picCanvas)
        {
            if (!isValid) return;
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Maroon, 3);
            PointF[] points = new PointF[4];
            points[0] = new PointF((picCanvas.Width / 2), (picCanvas.Height / 2) - (mHeight * SF));
            points[1] = new PointF((picCanvas.Width / 2) + (mWidth * SF), (picCanvas.Height / 2) - (mHeight * SF));
            points[2] = new PointF((picCanvas.Width / 2), (picCanvas.Height / 2) + (mHeight * SF));
            points[3] = new PointF((picCanvas.Width / 2) - (mWidth * SF), (picCanvas.Height / 2) + (mHeight * SF));
            mGraph.DrawPolygon(mPen, points);
        }
    }
}
