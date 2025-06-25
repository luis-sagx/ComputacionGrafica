using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Algorithms.Domain.Abstract;
using System.Windows.Forms;
using Algorithms.Utils;

namespace Algorithms.Algorithm
{
    public class FloodFillAlgorithm : AlgorithmCalculator
    {
        private Bitmap _canvas;
        private Color _fillColor = Color.Red;
        private readonly Color _polygonColor = Color.Black;
        private int _ordinal = 1;

        public Color FillColor
        {
            get => _fillColor;
            set => _fillColor = value;
        }

        public void ReadData(TextBox txtSides)
        {
            if (!int.TryParse(txtSides.Text, out int sides) || sides < 3)
            {
                MessageBox.Show("Ingrese un número entero mayor o igual a 3", "Error");
                txtSides.Focus();
                txtSides.Clear();
                throw new ArgumentException("Número de lados inválido");
            }
        }

        public void InitializeData(TextBox txtSides, PictureBox picCanvas)
        {
            txtSides.Text = "";
            txtSides.Focus();
            picCanvas.Refresh();
            _ordinal = 1;
        }

        public override void Draw(PictureBox picCanvas)
        {
            // Implementación requerida por la clase abstracta
        }

        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas)
        {
            if (_canvas == null)
            {
                MessageBox.Show("Primero dibuje la figura.");
                return;
            }

            Color targetColor = _canvas.GetPixel(x, y);
            await Task.Run(() => FloodFillRecursive(x, y, targetColor, picCanvas));
        }

        private void FloodFillRecursive(int x, int y, Color targetColor, PictureBox picCanvas)
        {
            if (x < 0 || y < 0 || x >= _canvas.Width || y >= _canvas.Height)
                return;

            if (!ColorHelper.ColorsMatch(_canvas.GetPixel(x, y), targetColor) ||
                ColorHelper.ColorsMatch(_canvas.GetPixel(x, y), _fillColor))
                return;

            _canvas.SetPixel(x, y, _fillColor);

            picCanvas.Invoke((MethodInvoker)(() =>
            {
                picCanvas.Image = _canvas;
            }));

            Thread.Sleep(AnimationDelay);

            FloodFillRecursive(x, y - 1, targetColor, picCanvas);
            FloodFillRecursive(x + 1, y, targetColor, picCanvas);
            FloodFillRecursive(x, y + 1, targetColor, picCanvas);
            FloodFillRecursive(x - 1, y, targetColor, picCanvas);
        }

        public void PlotPolygon(int sides, PictureBox picCanvas)
        {
            _canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            var polygonPoints = PolygonGenerator.GenerateCenteredPolygon(sides, picCanvas.Size);

            using (Graphics g = Graphics.FromImage(_canvas))
            {
                g.Clear(Color.White);
                mPen = new Pen(_polygonColor, 3);

                for (int j = 0; j < sides; j++)
                {
                    PointF startPoint = polygonPoints[j];
                    PointF endPoint = polygonPoints[(j + 1) % sides];
                    g.DrawLine(mPen, startPoint, endPoint);
                    AnimationPause();
                }
            }

            picCanvas.Image = _canvas;
        }
    }
}