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
                    RedibujarTodo();
                }
            }
        }

        private void RedibujarTodo()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics mGraph = Graphics.FromImage(bmp))
            {
                mGraph.Clear(Color.White);

                using (Pen penClip = new Pen(Color.DarkGreen, 3))
                    mGraph.DrawRectangle(penClip, rectRecorte);

                if (puntoInicio.HasValue)
                {
                    using (Pen bluePen = new Pen(Color.Blue, 3))
                        mGraph.DrawRectangle(bluePen, puntoInicio.Value.X - 1, puntoInicio.Value.Y - 1, 2, 2);
                }

                if (puntoInicio.HasValue && puntoFin.HasValue && !mostrarRecorte)
                {
                    using (Pen linePen = new Pen(Color.DarkBlue, 2))
                        mGraph.DrawLine(linePen, puntoInicio.Value, puntoFin.Value);

                    using (Pen bluePen = new Pen(Color.Blue, 3))
                        mGraph.DrawRectangle(bluePen, puntoFin.Value.X - 1, puntoFin.Value.Y - 1, 2, 2);
                }
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }

        private void AplicarRecorte()
        {
            var algoritmo = new CohenSutherlandAlgorithm(rectRecorte);

            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics mGraph = Graphics.FromImage(bmp))
            {
                mGraph.Clear(Color.White);

                using (Pen penClip = new Pen(Color.DarkGreen, 3))
                    mGraph.DrawRectangle(penClip, rectRecorte);

                var start = puntoInicio.Value;
                var end = puntoFin.Value;

                using (Pen penOrig = new Pen(Color.LightGray, 2))
                    mGraph.DrawLine(penOrig, start, end);

                bool visible = algoritmo.ClipLine(start, end, out Point clippedStart, out Point clippedEnd);

                if (visible)
                {
                    using (Pen redPen = new Pen(Color.Red, 3))
                        mGraph.DrawLine(redPen, clippedStart, clippedEnd);
                }
                else
                {
                    MessageBox.Show("The line is completely outside the cut area.");
                }
            }

            mostrarRecorte = true;
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
            string message = "✂️ Line Clipping Help – Cohen-Sutherland Algorithm\n\n" +
                             "This tool allows you to clip lines using a predefined rectangular clipping window.\n\n" +
                             "Instructions:\n" +
                             "1. A fixed rectangle is shown on the canvas — this is the clipping region.\n\n" +
                             "2. To draw a line:\n" +
                             "   - Left-click once to set the starting point of the line.\n" +
                             "   - Left-click again to set the ending point of the line.\n\n" +
                             "3. Once both endpoints are set:\n" +
                             "   - Right-click to apply the Cohen-Sutherland line clipping algorithm.\n\n" +
                             "Visualization:\n" +
                             "🔴 The part of the line that remains inside the rectangle is drawn in red.\n" +
                             "⚪ The part of the line that is outside (clipped) is shown in gray.\n\n" +
                             "📝 Tip: You can repeat this process to clip multiple lines inside the same rectangle.";

            MessageBox.Show(message, "Help - Cohen-Sutherland Line Clipping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
