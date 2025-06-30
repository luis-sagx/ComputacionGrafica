using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Utils;
using System.Windows.Forms;

namespace Algorithms.Domain.Abstract
{
    public abstract class FillAlgorithm : AlgorithmCalculator
    {
        protected Bitmap _canvas;
        protected Color _fillColor = Color.Red;
        protected readonly Color _borderColor = Color.Black;
        protected int _sides = 3;
        protected bool _isStar = false;

        public Color FillColor
        {
            get => _fillColor;
            set => _fillColor = value;
        }

        public void ReadData(TextBox txtLados, bool esEstrella)
        {
            if (!int.TryParse(txtLados.Text, out _sides) || _sides < 3)
            {
                MessageBox.Show("Ingrese un número entero mayor o igual a 3", "Error");
                txtLados.Focus();
                txtLados.Clear();
                throw new ArgumentException("Número de lados inválido");
            }

            _isStar = esEstrella;
        }


        public void InitializeData(TextBox txtSides, ComboBox chkStar, PictureBox picCanvas)
        {
            txtSides.Text = "";
            if (chkStar != null)
            {
                chkStar.SelectedIndex = 0;
                _isStar = false;
            }
            txtSides.Focus();
            picCanvas.Refresh();
        }

        public abstract Task FillAsync(int x, int y, PictureBox picCanvas);

        public void PlotFigure(PictureBox picCanvas)
        {
            _canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            var points = _isStar ?
                ShapeGenerator.GenerateStar(_sides, picCanvas.Size) :
                ShapeGenerator.GenerateCenteredPolygon(_sides, picCanvas.Size);

            using (Graphics mGraph = Graphics.FromImage(_canvas))
            {
                mGraph.Clear(Color.White);
                mPen = new Pen(_borderColor, 3);

                for (int j = 0; j < points.Count; j++)
                {
                    PointF start = points[j];
                    PointF end = points[(j + 1) % points.Count];
                    mGraph.DrawLine(mPen, start, end);
                    AnimationPause();
                }
            }

            picCanvas.Image = _canvas;
        }

        protected bool IsValidPixel(int x, int y)
        {
            return x >= 0 && y >= 0 && x < _canvas.Width && y < _canvas.Height;
        }

        protected bool ShouldFill(Color current, Color target)
        {
            return ColorHelper.ColorsMatch(current, target) &&
                   !ColorHelper.ColorsMatch(current, _fillColor);
        }
    }
}