using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ejercicios2P.Algorithms;

namespace Ejercicios2P.Views
{
    public partial class FrmSutherlandHodgman : Form
    {
        private List<Point> polygon = new List<Point>();
        private Rectangle rectClip;
        private bool mostrarRecorte = false;
        private List<Point> clippedPolygon;

        public FrmSutherlandHodgman()
        {
            InitializeComponent();
            picCanvas.Image = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.MouseClick += picCanvas_MouseClick;

            rectClip = new Rectangle(picCanvas.Width / 4, picCanvas.Height / 4, picCanvas.Width / 2, picCanvas.Height / 2);

            ReDraw();
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                polygon.Add(e.Location);
                mostrarRecorte = false;
                ReDraw();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (polygon.Count < 3)
                {
                    MessageBox.Show("El polígono debe tener al menos 3 puntos.");
                    return;
                }

                clippedPolygon = SutherlandHodgmanAlgorithm.ClipPolygon(polygon, rectClip);
                mostrarRecorte = true;
                ReDraw();
            }
        }

        private void ReDraw()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                using (Pen penClip = new Pen(Color.DarkGreen, 2))
                {
                    g.DrawRectangle(penClip, rectClip);
                }

                if (polygon.Count > 1 && !mostrarRecorte)
                {
                    using (Pen polyPen = new Pen(Color.Orange, 2))
                    {
                        g.DrawPolygon(polyPen, polygon.ToArray());
                    }
                }

                if (mostrarRecorte && clippedPolygon != null && clippedPolygon.Count > 1)
                {
                    using (Pen clippedPen = new Pen(Color.Red, 2))
                    {
                        g.DrawPolygon(clippedPen, clippedPolygon.ToArray());
                    }
                }

                foreach (var point in polygon)
                {
                    using (Pen penPoint = new Pen(Color.Red, 3))
                    {
                        g.DrawRectangle(penPoint, point.X, point.Y, 2,2);
                    }
                }
            }

            if (picCanvas.Image != null)
                picCanvas.Image.Dispose();

            picCanvas.Image = bmp;
            picCanvas.Invalidate();
        }
    }
}
