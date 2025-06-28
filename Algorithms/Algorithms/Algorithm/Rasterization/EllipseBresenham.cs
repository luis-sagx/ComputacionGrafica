using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Domain.Abstract;
using System.Windows.Forms;

namespace Algorithms.Algorithm.Rasterization
{
    public class EllipseBresenham : EllipseAlgorithm
    {
        public override void Draw(PictureBox picCanvas)
        {
            InitializeDrawingTools(picCanvas, Color.Purple);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            int cx = centerX + Center.X;
            int cy = centerY - Center.Y;

            DrawAxes(picCanvas, centerX, centerY);

            int x = 0;
            int y = Ry;

            double rx2 = Rx * Rx;
            double ry2 = Ry * Ry;
            double px = 0;
            double py = 2 * rx2 * y;

            double p1 = ry2 - (rx2 * Ry) + (0.25 * rx2);


            // Región 1
            while (px < py)
            {
                DibujarPuntosSimetricos(cx, cy, x, y, p1);
                x++;
                px += 2 * ry2;
                if (p1 < 0)
                {
                    p1 += ry2 + px;
                }
                else
                {
                    y--;
                    py -= 2 * rx2;
                    p1 += ry2 + px - py;
                }
                AnimationPause();
            }

            // Región 2
            double p2 = ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2;

            while (y >= 0)
            {
                DibujarPuntosSimetricos(cx, cy, x, y, p2);
                y--;
                py -= 2 * rx2;
                if (p2 > 0)
                {
                    p2 += rx2 - py;
                }
                else
                {
                    x++;
                    px += 2 * ry2;
                    p2 += rx2 - py + px;
                }
                AnimationPause();
            }
        }

        private void DibujarPuntosSimetricos(int cx, int cy, int x, int y, double p)
        {
            var puntos = new List<Point>
            {
                new Point(cx + x, cy + y),
                new Point(cx - x, cy + y),
                new Point(cx + x, cy - y),
                new Point(cx - x, cy - y)
            };

            foreach (var punto in puntos)
            {
                DrawPixel(punto.X, punto.Y);
            }

        }
    }
}