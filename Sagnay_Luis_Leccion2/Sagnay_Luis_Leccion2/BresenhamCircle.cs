using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagnay_Luis_Leccion2
{
    public class BresenhamCircle
    {
        private Graphics mGraph;
        private Pen mPen;
        private int centerX = 0, centerY = 0, radius = 120;


        public void InitializeData(PictureBox picCanvas)
        {
            picCanvas.Refresh();
        }

        private void DrawPixel(int x, int y)
        {
            mGraph.DrawRectangle(mPen, x, y, 1, 1);
        }

        private void InitializeDrawingTools(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Orange, 1);
        }


        public void Draw(PictureBox picCanvas)
        {
            InitializeDrawingTools(picCanvas);

            int canvasCenterX = picCanvas.Width / 2;
            int canvasCenterY = picCanvas.Height / 2;

            int x = 0;
            int y = radius;
            int p = 1 - radius;

            DrawSymmetricPointsAnimated(x, y, canvasCenterX, canvasCenterY, p);

            while (x < y)
            {
                x++;
                p += (p < 0) ? 2 * x + 1 : 2 * (x - y--) + 1;
                DrawSymmetricPointsAnimated(x, y, canvasCenterX, canvasCenterY, p);
            }
        }

        private void DrawSymmetricPointsAnimated(int x, int y, int canvasCenterX, int canvasCenterY, int p)
        {
            int cx = canvasCenterX + centerX;
            int cy = canvasCenterY - centerY;

            var points = new List<Point>
        {
            new Point(cx + x, cy + y),
            new Point(cx - x, cy + y),
            new Point(cx + x, cy - y),
            new Point(cx - x, cy - y),
            new Point(cx + y, cy + x),
            new Point(cx - y, cy + x),
            new Point(cx + y, cy - x),
            new Point(cx - y, cy - x)
        };

            foreach (var point in points)
            {
                DrawPixel(point.X, point.Y);
            }
        }
    }
}
