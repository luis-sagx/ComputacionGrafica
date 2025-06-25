using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Ejercicios2P.Algorithms.Line;

namespace Ejercicios2P.DDA
{
    public class DDAAlgorithm : LineAlgorithm
    {
        public override void Draw(PictureBox picCanvas, DataGridView dgv = null)
        {
            InitializeDrawingTools(picCanvas, Color.DarkGreen);

            int dx = EndPoint.X - StartPoint.X;
            int dy = EndPoint.Y - StartPoint.Y;
            float m = dx != 0 ? (float)dy / dx : float.PositiveInfinity;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xk = StartPoint.X;
            float yk = StartPoint.Y;

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            DrawAxes(picCanvas, centerX, centerY);

            for (int i = 0; i <= steps; i++)
            {
                int xCanvas = (int)Math.Round(centerX + xk);
                int yCanvas = (int)Math.Round(centerY - yk);

                DrawPixel(xCanvas, yCanvas);

                dgv?.Rows.Add(i, Math.Round(xk, 2), Math.Round(yk, 2));

                AnimationPause();

                if (Math.Abs(m) <= 1)
                {
                    xk += (dx >= 0) ? 1 : -1;
                    yk += (dx >= 0) ? m : -m;
                }
                else
                {
                    yk += (dy >= 0) ? 1 : -1;
                    xk += (dy >= 0) ? 1 / m : -1 / m;
                }
            }
        }
    }
}
