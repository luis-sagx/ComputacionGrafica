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

namespace Algorithms.Views
{
    public partial class FrmBezier : Form
    {
        private CurveAlgorithm curva = new BezierCurve();

        public FrmBezier()
        {
            InitializeComponent();
            picCanvas.MouseClick += PicCanvas_MouseClick;
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            curva.AgregarPunto(e.Location);
            Redraw();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            curva.Resetear();
            Redraw();
        }

        private void Redraw()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.AliceBlue);

                foreach (var p in curva.PuntosControl)
                    g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);

                if (curva.PuntosControl.Count > 1)
                    g.DrawLines(Pens.Gray, curva.PuntosControl.ToArray());

                if (curva.CurvaGenerada.Count > 1)
                    g.DrawLines(Pens.Red, curva.CurvaGenerada.ToArray());
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }
    }

}