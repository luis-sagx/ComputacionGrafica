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
    public class CircleBresenham : EllipseAlgorithm
    {
        public override void Draw(PictureBox picCanvas)
        {
            InitializeDrawingTools(picCanvas, Color.Blue);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            int cx = centerX + Center.X;
            int cy = centerY - Center.Y;

            DrawAxes(picCanvas, centerX, centerY);

            int x = 0;
            int y = Ry;
            int p = 1 - Ry;

            DibujarPuntosSimetricos(cx, cy, x, y, p);

            while (x < y)
            {
                x++;
                p += (p < 0) ? 2 * x + 1 : 2 * (x - y--) + 1;
                AnimationPause();
                DibujarPuntosSimetricos(cx, cy, x, y, p);
            }
        }

        private void DibujarPuntosSimetricos(int cx, int cy, int x, int y, int p)
        {
            var puntos = new List<Point>
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

            foreach (var punto in puntos)
                DrawPixel(punto.X, punto.Y);

        }
    }
}
