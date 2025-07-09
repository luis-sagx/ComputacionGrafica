using System;
using System.Drawing;
using System.Windows.Forms;
using Sagnay_Luis_Ex2.Domain;

namespace Sagnay_Luis_Ex2
{
    public class BresenhamCircle : CircleAlgorithm
    {
        public override void Draw(PictureBox picCanvas, Color colorSeleccionado)
        {
            InitializeDrawingTools((Bitmap)picCanvas.Image, colorSeleccionado);

            InitializeDrawingTools(picCanvas, colorSeleccionado);

            int r = CalcularRadio();

            int x = 0;
            int y = r;
            int d = 3 - 2 * r;

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;


            while (x <= y)
            {
                DibujarSimetría(centerX, centerY, Centro.X, Centro.Y, x, y);
                AnimationPause();

                if (d < 0)
                {
                    d += 4 * x + 6;
                }
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }
        }

        private void DibujarSimetría(int cx, int cy, int xc, int yc, int x, int y)
        {
            DibujarPixel(cx + xc + x, cy - yc - y);
            DibujarPixel(cx + xc - x, cy - yc - y);
            DibujarPixel(cx + xc + x, cy - yc + y);
            DibujarPixel(cx + xc - x, cy - yc + y);
            DibujarPixel(cx + xc + y, cy - yc - x);
            DibujarPixel(cx + xc - y, cy - yc - x);
            DibujarPixel(cx + xc + y, cy - yc + x);
            DibujarPixel(cx + xc - y, cy - yc + x);
        }

        private void DibujarPixel(int x, int y)
        {
            DrawPixel(x, y);
        }
    }
}
