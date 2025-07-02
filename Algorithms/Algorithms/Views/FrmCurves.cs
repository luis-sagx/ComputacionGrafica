using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Algorithm.Curves;
using Algorithms.Domain.Abstract;
using Algorithms.Domain.Interface;

namespace Algorithms.Views
{
    public partial class FrmCurves : Form
    {
        private ICurveAlgorithm _curve;

        public FrmCurves()
        {
            InitializeComponent();
            rbBezier.Checked = true;
            CrearNuevaCurva();

            picCanvas.MouseClick += PicCanvas_MouseClick;
        }

        private void FrmCurves_Load(object sender, EventArgs e)
        {
            Redraw();
        }

        private void CrearNuevaCurva()
        {
            if (rbBezier.Checked)
            {
                _curve = new BezierCurve();
            }
            else
            {
                _curve = new BSplineCurve();
            }
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            _curve.AddPoint(e.Location);
            Redraw();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (_curve.ControlPoints.Count <= 1)
            {
                MessageBox.Show("You must enter at least 2 points to generate the curve.", "Warning");
                return;
            }

            _curve.GenerateCurve();
            Redraw();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            CrearNuevaCurva();
            Redraw();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)?.Checked == true)
            {
                CrearNuevaCurva();
                Redraw();
            }
        }

        private void Redraw()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics mGraph = Graphics.FromImage(bmp))
            {
                mGraph.Clear(Color.AliceBlue);

                foreach (var p in _curve.ControlPoints)
                    mGraph.FillEllipse(Brushes.Black, p.X - 2, p.Y - 2, 4, 4);

                if (_curve.ControlPoints.Count > 1)
                    mGraph.DrawLines(Pens.DarkBlue, _curve.ControlPoints.ToArray());

                if (_curve.GeneratedCurve.Count > 1)
                    using (Pen redThickPen = new Pen(Color.Brown, 3f)) 
                    {
                        mGraph.DrawLines(redThickPen, _curve.GeneratedCurve.ToArray());
                    }
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "🧩 Curve Drawing Help – Bézier and B-Spline\n\n" +
                             "This tool allows you to draw smooth curves using two different algorithms.\n\n" +
                             "Step-by-step instructions:\n\n" +
                             "1. Select the curve type at the top: Bézier Curve or B-Spline Curve\n\n" +
                             "2. Draw control points:\n" +
                             "   - Left-click on the canvas to place control points.\n" +
                             "   - The points are connected with straight gray lines as a reference.\n\n" +
                             "3. *enerate the curve:\n" +
                             "   - Click the **Draw Curve** button to display the generated curve in turquoise.\n" +
                             "     (The curve will only appear if enough points are provided.)\n\n" +
                             "Buttons:\n" +
                             "🎨 Draw Curve – Generates the selected curve from the control points.\n" +
                             "🔁 Reset – Clears the canvas and control points so you can start over.\n" +
                             "↩️ Back – Returns to the main menu.\n\n" +
                             "Notes:\n" +
                             "👉 Bézier curves require at least 2 points.\n" +
                             "👉 B-Spline curves require at least 4 points.\n" +
                             "👉 You can switch between curve types at any time.";

            MessageBox.Show(message, "Help - Curve Drawing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}