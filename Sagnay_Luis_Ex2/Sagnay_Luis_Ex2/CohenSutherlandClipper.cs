using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Sagnay_Luis_Ex2.Domain;

namespace Sagnay_Luis_Ex2
{
    public class CohenSutherlandClipper : LineAlgorithm
    {
        public Rectangle ventana;

        const int INSIDE = 0; // 0000
        const int LEFT = 1;   // 0001
        const int RIGHT = 2;  // 0010
        const int BOTTOM = 4; // 0100
        const int TOP = 8;    // 1000

        private int CalcularCodigo(Point p)
        {
            int codigo = INSIDE;

            if (p.X < ventana.Left)
                codigo |= LEFT;
            else if (p.X > ventana.Right)
                codigo |= RIGHT;

            if (p.Y < ventana.Top)
                codigo |= TOP;
            else if (p.Y > ventana.Bottom)
                codigo |= BOTTOM;

            return codigo;
        }

        public override void Draw(PictureBox picCanvas, Color colorSeleccionado)
        {
            InitializeDrawingTools((Bitmap)picCanvas.Image, colorSeleccionado);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            Point p1 = StartPoint;
            Point p2 = EndPoint;

            Point originalStart = p1;
            Point originalEnd = p2;

            int codigo1 = CalcularCodigo(p1);
            int codigo2 = CalcularCodigo(p2);

            bool aceptado = false;

            while (true)
            {
                if ((codigo1 | codigo2) == 0)
                {
                    aceptado = true;
                    break;
                }
                else if ((codigo1 & codigo2) != 0)
                {
                    break;
                }
                else
                {
                    int codigoFuera = codigo1 != 0 ? codigo1 : codigo2;
                    int x = 0, y = 0;

                    if ((codigoFuera & TOP) != 0)
                    {
                        x = p1.X + (p2.X - p1.X) * (ventana.Top - p1.Y) / (p2.Y - p1.Y);
                        y = ventana.Top;
                    }
                    else if ((codigoFuera & BOTTOM) != 0)
                    {
                        x = p1.X + (p2.X - p1.X) * (ventana.Bottom - p1.Y) / (p2.Y - p1.Y);
                        y = ventana.Bottom;
                    }
                    else if ((codigoFuera & RIGHT) != 0)
                    {
                        y = p1.Y + (p2.Y - p1.Y) * (ventana.Right - p1.X) / (p2.X - p1.X);
                        x = ventana.Right;
                    }
                    else if ((codigoFuera & LEFT) != 0)
                    {
                        y = p1.Y + (p2.Y - p1.Y) * (ventana.Left - p1.X) / (p2.X - p1.X);
                        x = ventana.Left;
                    }

                    if (codigoFuera == codigo1)
                    {
                        p1 = new Point(x, y);
                        codigo1 = CalcularCodigo(p1);
                    }
                    else
                    {
                        p2 = new Point(x, y);
                        codigo2 = CalcularCodigo(p2);
                    }
                }
            }

            Point ToPantalla(Point p) => new Point(centerX + p.X, centerY - p.Y);

            Pen penOriginal = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(penOriginal, ToPantalla(originalStart), ToPantalla(originalEnd));

            if (aceptado)
            {
                Pen penInterior = new Pen(Color.Red, 2);
                mGraph.DrawLine(penInterior, ToPantalla(p1), ToPantalla(p2));

                Pen penExterior = new Pen(Color.Gray, 2);

                if (originalStart != p1)
                    mGraph.DrawLine(penExterior, ToPantalla(originalStart), ToPantalla(p1));

                if (originalEnd != p2)
                    mGraph.DrawLine(penExterior, ToPantalla(p2), ToPantalla(originalEnd));
            }
            else
            {
                Pen penRechazada = new Pen(Color.DarkGray, 2);
                mGraph.DrawLine(penRechazada, ToPantalla(originalStart), ToPantalla(originalEnd));
            }
        }

    }
}
