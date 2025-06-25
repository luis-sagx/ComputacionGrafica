using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Domain.Abstract;
using System.Windows.Forms;

namespace Algorithms.Algorithm
{
    public class CircleBresenham : CircleAlgorithm
    {
        public override void Draw(PictureBox picCanvas)
        {
            InitializeDrawingTools(picCanvas, Color.Blue);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            DrawAxes(picCanvas, centerX, centerY);

            int x = 0;
            int y = Radius;
            int p = 1 - Radius;
            int step = 0;

            DrawSymmetricPointsAnimated(x, y, centerX, centerY, p);
            step++;

            while (x < y)
            {
                x++;
                p += (p < 0) ? 2 * x + 1 : 2 * (x - y--) + 1;
                AnimationPause();
                DrawSymmetricPointsAnimated(x, y, centerX, centerY, p);
            }
        }

        private void DrawSymmetricPointsAnimated(int x, int y, int centerX, int centerY, int p)
        {
            int cx = centerX + Center.X;
            int cy = centerY - Center.Y;

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

