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
    public partial class FrmBSpline : Form
    {
        private CurveAlgorithm curva = new BSplineCurve();

        public FrmBSpline()
        {
            InitializeComponent();
            picCanvas.MouseClick += PicCanvas_MouseClick;
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            curva.AgregarPunto(e.Location);
            Redibujar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            curva.Resetear();
            Redibujar();
        }

        private void Redibujar()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

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
