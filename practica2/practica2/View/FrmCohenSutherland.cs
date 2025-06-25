using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica2.Algorithms;

namespace practica2.View
{
    public partial class FrmCohenSutherland : Form
    {
        private Point? puntoInicio = null;
        private Point? puntoFin = null;
        private System.Drawing.Rectangle rectRecorte;
        private bool mostrarRecorte = false;

        public FrmCohenSutherland()
        {
            InitializeComponent();
            picCanvas.Image = new Bitmap(picCanvas.Width, picCanvas.Height);

            picCanvas.MouseDown -= picCanvas_MouseDown;
            picCanvas.MouseDown += picCanvas_MouseDown;

            picCanvas.BackColor = Color.White;
            picCanvas.SizeMode = PictureBoxSizeMode.Normal;

            RedibujarTodo();
        }

        private void FrmCohenShutteredLand_Load(object sender, EventArgs e)
        {
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!puntoInicio.HasValue)
                {
                    puntoInicio = e.Location;
                    mostrarRecorte = false;
                    RedibujarTodo();
                }
                else if (!puntoFin.HasValue)
                {
                    puntoFin = e.Location;
                    mostrarRecorte = false;
                    RedibujarTodo();
                }
                else
                {
                    puntoInicio = e.Location;
                    puntoFin = null;
                    mostrarRecorte = false;
                    RedibujarTodo();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (puntoInicio.HasValue && puntoFin.HasValue)
                {
                    MessageBox.Show("Aplicando algoritmo de Cohen-Sutherland...");
                    AplicarRecorte();
                }
                else
                {
                    puntoInicio = null;
                    puntoFin = null;
                    mostrarRecorte = false;
                    MessageBox.Show("Limpiando pantalla...");
                    RedibujarTodo();
                }
            }
        }
        private void RedibujarTodo()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                rectRecorte = new System.Drawing.Rectangle(picCanvas.Width / 4, picCanvas.Height / 4, picCanvas.Width / 2, picCanvas.Height / 2);

                using (Pen mPen = new Pen(Color.DarkGreen, 3))
                {
                    g.DrawRectangle(mPen, rectRecorte);
                }

                if (puntoInicio.HasValue)
                {
                    using (Pen bluePen = new Pen(Color.Blue, 3))
                    {
                        g.DrawRectangle(bluePen, puntoInicio.Value.X - 1, puntoInicio.Value.Y - 1, 2, 2);
                    }
                }

                // Dibuja línea si ambos puntos existen y no se está mostrando el recorte
                if (puntoInicio.HasValue && puntoFin.HasValue && !mostrarRecorte)
                {
                    using (Pen linePen = new Pen(Color.DarkBlue, 2))
                    {
                        g.DrawLine(linePen, puntoInicio.Value, puntoFin.Value);
                    }

                    using (Pen bluePen = new Pen(Color.Blue, 3))
                    {
                        g.DrawRectangle(bluePen, puntoFin.Value.X - 1, puntoFin.Value.Y - 1, 2, 2);
                    }
                }
            }

            if (picCanvas.Image != null)
                picCanvas.Image.Dispose();
            picCanvas.Image = bmp;
            picCanvas.Invalidate();
            picCanvas.Refresh();
        }

        private void AplicarRecorte()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                using (Pen mPen = new Pen(Color.DarkGreen, 3))
                {
                    g.DrawRectangle(mPen, rectRecorte);
                }

                var (x1, y1) = (puntoInicio.Value.X, puntoInicio.Value.Y);
                var (x2, y2) = (puntoFin.Value.X, puntoFin.Value.Y);

                var handler = new CohenSutherlandAlgorithm(
                    rectRecorte.Left,
                    rectRecorte.Right,
                    rectRecorte.Top,
                    rectRecorte.Bottom
                );

                bool visible = handler.clipLine(x1, y1, x2, y2);

                using (Pen linePen = new Pen(Color.LightGray, 2))
                {
                    g.DrawLine(linePen, x1, y1, x2, y2);
                }

                if (visible)
                {
                    var clipped = handler.GetClippedLine();
                    if (clipped.HasValue)
                    {
                        var (cx1, cy1, cx2, cy2) = clipped.Value;
                        using (Pen redPen = new Pen(Color.DarkBlue, 3))
                        {
                            g.DrawLine(redPen, cx1, cy1, cx2, cy2);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La línea está completamente fuera del área de recorte.");
                }
            }

            mostrarRecorte = true;
            if (picCanvas.Image != null)
                picCanvas.Image.Dispose();
            picCanvas.Image = bmp;
            picCanvas.Invalidate();
            picCanvas.Refresh();
        }
    }
}