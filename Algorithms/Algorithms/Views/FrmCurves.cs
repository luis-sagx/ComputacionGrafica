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
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                foreach (var p in _curve.ControlPoints)
                    g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);

                if (_curve.ControlPoints.Count > 1)
                    g.DrawLines(Pens.Gray, _curve.ControlPoints.ToArray());

                if (_curve.GeneratedCurve.Count > 1)
                    g.DrawLines(Pens.Red, _curve.GeneratedCurve.ToArray());
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }
    }
}