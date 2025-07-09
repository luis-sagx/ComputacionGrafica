using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sagnay_Luis_Ex2.Domain;

namespace Sagnay_Luis_Ex2
{
    public class BezierCubic : AlgorithmCalculator
    {
        public List<Point> PuntosControl = new List<Point>();

        public override void Draw(PictureBox picCanvas, Color colorSeleccionado)
        {
            if (PuntosControl.Count != 4)
                return;

            InitializeDrawingTools((Bitmap)picCanvas.Image, colorSeleccionado);

            InitializeDrawingTools(picCanvas, colorSeleccionado);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            float t = 0;
            float step = 0.01f;

            while (t <= 1)
            {
                float x = (float)(
                    Math.Pow(1 - t, 3) * PuntosControl[0].X +
                    3 * Math.Pow(1 - t, 2) * t * PuntosControl[1].X +
                    3 * (1 - t) * Math.Pow(t, 2) * PuntosControl[2].X +
                    Math.Pow(t, 3) * PuntosControl[3].X);

                float y = (float)(
                    Math.Pow(1 - t, 3) * PuntosControl[0].Y +
                    3 * Math.Pow(1 - t, 2) * t * PuntosControl[1].Y +
                    3 * (1 - t) * Math.Pow(t, 2) * PuntosControl[2].Y +
                    Math.Pow(t, 3) * PuntosControl[3].Y);

                int xCanvas = (int)Math.Round(centerX + x);
                int yCanvas = (int)Math.Round(centerY - y);

                DrawPixel(xCanvas, yCanvas);
                AnimationPause();

                t += step;
            }
        }
    }
}
