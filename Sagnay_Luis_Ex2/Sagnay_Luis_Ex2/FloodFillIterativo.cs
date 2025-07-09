using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sagnay_Luis_Ex2.Domain;

namespace Sagnay_Luis_Ex2
{
    public class FloodFillIterativo : AlgorithmCalculator
    {
        public Point PuntoInicio { get; set; }

        public override void Draw(PictureBox picCanvas, Color colorSeleccionado)
        {
            InitializeDrawingTools((Bitmap)picCanvas.Image, colorSeleccionado);
            InitializeDrawingTools(picCanvas, colorSeleccionado);

            Bitmap bmp = new Bitmap(picCanvas.Image ?? new Bitmap(picCanvas.Width, picCanvas.Height));
            Graphics g = Graphics.FromImage(bmp);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            int xInicio = centerX + PuntoInicio.X;
            int yInicio = centerY - PuntoInicio.Y;

            if (xInicio < 0 || xInicio >= bmp.Width || yInicio < 0 || yInicio >= bmp.Height)
                return;

            Color colorObjetivo = bmp.GetPixel(xInicio, yInicio);
            Color colorRelleno = DrawingColor;

            if (colorObjetivo.ToArgb() == colorRelleno.ToArgb())
                return;

            Stack<Point> pila = new Stack<Point>();
            pila.Push(new Point(xInicio, yInicio));

            while (pila.Count > 0)
            {
                Point p = pila.Pop();
                int x = p.X;
                int y = p.Y;

                if (x < 0 || x >= bmp.Width || y < 0 || y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(x, y).ToArgb() != colorObjetivo.ToArgb())
                    continue;

                bmp.SetPixel(x, y, colorRelleno);

                pila.Push(new Point(x + 1, y));
                pila.Push(new Point(x - 1, y));
                pila.Push(new Point(x, y + 1));
                pila.Push(new Point(x, y - 1));
            }

            picCanvas.Image = bmp;
        }
    }
}
