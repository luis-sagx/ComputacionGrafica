using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sagnay_Luis_Ex2
{
    public partial class FrmPaint : Form
    {
        private Point puntoInicio, puntoFin;
        private bool isDrawing = false;
        private Bitmap lienzoBitmap;

        private Color colorSeleccionado = Color.Black; 



        private enum Herramienta { Ninguna, Linea, Circunferencia, Bezier, Relleno, Recorte }
        private Herramienta herramientaSeleccionada = Herramienta.Ninguna;

        private int clicsBezier = 0;
        private List<Point> puntosBezier = new List<Point>();

        private Rectangle ventanaRecorte = new Rectangle(-100, -100, 200, 200);

        public FrmPaint()
        {
            InitializeComponent();

            picCanvas.BackColor = Color.White;

            lienzoBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = lienzoBitmap;

            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseUp += PicCanvas_MouseUp;

        }
        private void btnLinea_Click(object sender, EventArgs e)
        {
            herramientaSeleccionada = Herramienta.Linea;
        }

        private void btnCircunferencia_Click(object sender, EventArgs e)
        {
            herramientaSeleccionada = Herramienta.Circunferencia;
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            herramientaSeleccionada = Herramienta.Bezier;
            clicsBezier = 0;
            puntosBezier.Clear();
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            herramientaSeleccionada = Herramienta.Relleno;
        }

        private void btnRecorte_Click(object sender, EventArgs e)
        {
            herramientaSeleccionada = Herramienta.Recorte;
            DibujarVentanaRecorte();
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (herramientaSeleccionada == Herramienta.Bezier)
            {
                if (clicsBezier < 4)
                {
                    puntosBezier.Add(ToCartesiano(e.Location));
                    clicsBezier++;

                    if (clicsBezier == 4)
                    {
                        BezierCubic bezier = new BezierCubic();
                        bezier.PuntosControl = new List<Point>(puntosBezier);
                        bezier.Draw(picCanvas, colorSeleccionado);
                        clicsBezier = 0;
                        puntosBezier.Clear();
                    }
                }
            }
            else
            {
                puntoInicio = e.Location;
                isDrawing = true;
            }
        }



        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return;

            puntoFin = e.Location;
            isDrawing = false;

            switch (herramientaSeleccionada)
            {
                case Herramienta.Linea:
                    DDAAlgorithm dda = new DDAAlgorithm();
                    dda.StartPoint = ToCartesiano(puntoInicio);
                    dda.EndPoint = ToCartesiano(puntoFin);
                    dda.DrawingColor = colorSeleccionado;
                    dda.Draw(picCanvas, colorSeleccionado);
                    break;

                case Herramienta.Circunferencia:
                    BresenhamCircle circle = new BresenhamCircle();
                    circle.Centro = ToCartesiano(puntoInicio);
                    circle.PuntoRadio = ToCartesiano(puntoFin);
                    circle.DrawingColor = colorSeleccionado;
                    circle.Draw(picCanvas, colorSeleccionado);
                    break;

                case Herramienta.Relleno:
                    FloodFillIterativo flood = new FloodFillIterativo();
                    flood.PuntoInicio = ToCartesiano(e.Location);
                    flood.DrawingColor = colorSeleccionado;
                    flood.Draw(picCanvas, colorSeleccionado);
                    break;

                case Herramienta.Recorte:
                    CohenSutherlandClipper clipper = new CohenSutherlandClipper();
                    clipper.StartPoint = ToCartesiano(puntoInicio);
                    clipper.EndPoint = ToCartesiano(puntoFin);
                    clipper.ventana = ventanaRecorte;
                    clipper.DrawingColor = colorSeleccionado;
                    clipper.Draw(picCanvas, colorSeleccionado);
                    break;
            }

        }

        private void DibujarVentanaRecorte()
        {
            if (lienzoBitmap == null) return;

            using (Graphics g = Graphics.FromImage(lienzoBitmap))
            {
                int cx = picCanvas.Width / 2;
                int cy = picCanvas.Height / 2;

                Pen pen = new Pen(Color.Red, 3);

                Rectangle r = ventanaRecorte;

                Rectangle rectPantalla = new Rectangle(
                    cx + r.Left,
                    cy - r.Bottom, 
                    r.Width,
                    r.Height);

                g.DrawRectangle(pen, rectPantalla);
            }

            picCanvas.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(lienzoBitmap))
            {
                g.Clear(Color.White);
            }

            picCanvas.BackColor = Color.White;

            herramientaSeleccionada = Herramienta.Ninguna;
            puntoInicio = Point.Empty;
            puntoFin = Point.Empty;
            isDrawing = false;
            clicsBezier = 0;
            puntosBezier.Clear();


            picCanvas.Invalidate(); 
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorSeleccionado = colorDialog1.Color;
                btnColor.BackColor = colorSeleccionado; 
            }
        }


        private Point ToCartesiano(Point mousePoint)
        {
            int centroX = picCanvas.Width / 2;
            int centroY = picCanvas.Height / 2;
            return new Point(mousePoint.X - centroX, centroY - mousePoint.Y);
        }
    }
}
