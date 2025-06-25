using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Algorithm;

namespace Algorithms.Views
{
    public partial class FrmCohenSutherland : Form
    {
        private Point? puntoInicio = null;
        private Point? puntoFin = null;
        private Rectangle rectRecorte;
        private bool mostrarRecorte = false;

        public FrmCohenSutherland()
        {
            InitializeComponent();
            picCanvas.Image = new Bitmap(picCanvas.Width, picCanvas.Height);
            //picCanvas.MouseDown += picCanvas_MouseDown;

            picCanvas.BackColor = Color.White;
            picCanvas.SizeMode = PictureBoxSizeMode.Normal;

            rectRecorte = new Rectangle(picCanvas.Width / 4, picCanvas.Height / 4, picCanvas.Width / 2, picCanvas.Height / 2);
            RedibujarTodo();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!puntoInicio.HasValue)
                {
                    puntoInicio = e.Location;
                    mostrarRecorte = false;
                }
                else if (!puntoFin.HasValue)
                {
                    puntoFin = e.Location;
                    mostrarRecorte = false;
                }
                else
                {
                    puntoInicio = e.Location;
                    puntoFin = null;
                    mostrarRecorte = false;
                }

                RedibujarTodo();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (puntoInicio.HasValue && puntoFin.HasValue)
                {
                    AplicarRecorte();
                }
                else
                {
                    puntoInicio = null;
                    puntoFin = null;
                    mostrarRecorte = false;
                    MessageBox.Show("Pantalla limpiada.");
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

                using (Pen penClip = new Pen(Color.DarkGreen, 3))
                    g.DrawRectangle(penClip, rectRecorte);

                if (puntoInicio.HasValue)
                {
                    using (Pen bluePen = new Pen(Color.Blue, 3))
                        g.DrawRectangle(bluePen, puntoInicio.Value.X - 1, puntoInicio.Value.Y - 1, 2, 2);
                }

                if (puntoInicio.HasValue && puntoFin.HasValue && !mostrarRecorte)
                {
                    using (Pen linePen = new Pen(Color.DarkBlue, 2))
                        g.DrawLine(linePen, puntoInicio.Value, puntoFin.Value);

                    using (Pen bluePen = new Pen(Color.Blue, 3))
                        g.DrawRectangle(bluePen, puntoFin.Value.X - 1, puntoFin.Value.Y - 1, 2, 2);
                }
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }

        private void AplicarRecorte()
        {
            var algoritmo = new CohenSutherlandAlgorithm(rectRecorte);

            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                using (Pen penClip = new Pen(Color.DarkGreen, 3))
                    g.DrawRectangle(penClip, rectRecorte);

                var start = puntoInicio.Value;
                var end = puntoFin.Value;

                using (Pen penOrig = new Pen(Color.LightGray, 2))
                    g.DrawLine(penOrig, start, end);

                bool visible = algoritmo.ClipLine(start, end, out Point clippedStart, out Point clippedEnd);

                if (visible)
                {
                    using (Pen redPen = new Pen(Color.Red, 3))
                        g.DrawLine(redPen, clippedStart, clippedEnd);
                }
                else
                {
                    MessageBox.Show("La línea está completamente fuera del área de recorte.");
                }
            }

            mostrarRecorte = true;
            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }
    }
}
