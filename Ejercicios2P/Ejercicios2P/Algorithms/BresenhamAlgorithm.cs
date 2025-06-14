using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios2P.Algorithms.Line;

namespace Ejercicios2P.Bresenham
{
    public class BresenhamAlgorithm : LineAlgorithm
    {
        public override void Draw(PictureBox picCanvas, DataGridView dgv = null)
        {
            InitializeDrawingTools(picCanvas, Color.Red);

            int dx = EndPoint.X - StartPoint.X;
            int dy = EndPoint.Y - StartPoint.Y;
            int absDx = Math.Abs(dx);
            int absDy = Math.Abs(dy);
            int sx = dx >= 0 ? 1 : -1;
            int sy = dy >= 0 ? 1 : -1;
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            DrawAxes(picCanvas, centerX, centerY);

            bool isXMajor = absDx > absDy;
            int p = isXMajor ? 2 * absDy - absDx : 2 * absDx - absDy;
            int steps = isXMajor ? absDx : absDy;
            int px = StartPoint.X;
            int py = StartPoint.Y;
            int step = 0;

            for (int i = 0; i <= steps; i++)
            {
                DrawPixel(centerX + px, centerY - py);
                dgv?.Rows.Add(step, px, py, p);
                AnimationPause();

                if (isXMajor)
                {
                    px += sx;
                    if (p < 0) p += 2 * absDy;
                    else { py += sy; p += 2 * (absDy - absDx); }
                }
                else
                {
                    py += sy;
                    if (p < 0) p += 2 * absDx;
                    else { px += sx; p += 2 * (absDx - absDy); }
                }
                step++;
            }
        }     
    }

}
