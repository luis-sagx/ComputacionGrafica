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
    public partial class FrmSutherlandHodgman : Form
    {
        private List<Point> polygon = new List<Point>();
        private List<Point> clippedPolygon = new List<Point>();
        private Rectangle rectClip;
        private bool mostrarRecorte = false;

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
                    MessageBox.Show("The polygon must have at least 3 points.", "Warning");
                    return;
                }

                var algoritmo = new SutherlandHodgmanAlgorithm(rectClip);
                clippedPolygon = algoritmo.ClipPolygon(polygon);
                mostrarRecorte = true;
                ReDraw();
            }
        }

        private void ReDraw()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics mGraph = Graphics.FromImage(bmp))
            {
                mGraph.Clear(Color.AliceBlue);

                using (Pen penClip = new Pen(Color.DarkGreen, 3))
                    mGraph.DrawRectangle(penClip, rectClip);

                if (polygon.Count > 1 && !mostrarRecorte)
                {
                    using (Pen polyPen = new Pen(Color.DarkBlue, 2))
                        mGraph.DrawPolygon(polyPen, polygon.ToArray());
                }

                if (mostrarRecorte && clippedPolygon.Count > 1)
                {
                    using (Pen clippedPen = new Pen(Color.Red, 2))
                        mGraph.DrawPolygon(clippedPen, clippedPolygon.ToArray());
                }

                foreach (var point in polygon)
                {
                    using (Pen penPoint = new Pen(Color.Red, 3))
                        mGraph.DrawRectangle(penPoint, point.X - 1, point.Y - 1, 2, 2);
                }
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "📐 Polygon Clipping Help\n\n" +
                             "This tool allows you to clip any polygon against a fixed rectangular clipping window.\n\n" +
                             "Instructions:\n" +
                             "1. A rectangular clipping area is already displayed on the canvas.\n\n" +
                             "2. To draw your polygon:\n" +
                             "   - Left-click inside the canvas to place each vertex of the polygon.\n" +
                             "   - As you click, the polygon shape is gradually formed.\n\n" +
                             "3. When you finish adding points:\n" +
                             "   - Right-click anywhere to apply the polygon clipping algorithm.\n\n" +
                             "Buttons:\n" +
                             "🔁 Reset – Clears the canvas and lets you start over.\n" +
                             "↩️ Back – Returns to the main menu form.\n\n" +
                             "Note:\n" +
                             "👉 Ensure the polygon is closed properly. The algorithm will handle open shapes automatically when clipping.";

            MessageBox.Show(message, "Help - Polygon Clipping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            polygon.Clear();
            clippedPolygon.Clear();
            mostrarRecorte = false;
            ReDraw(); 
        }
    }
}
