using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagnay_Luis_Leccion2
{
    public class FloodFillAlgorithm
    {
        private Graphics mGraph;
        private Pen mPen;
        private int animationDelay = 80;
        private Bitmap _canvas;
        private Color _fillColor = Color.Red;
        private readonly Color _polygonColor = Color.Black;
        private int _ordinal = 1;

        public int AnimationDelay
        {
            get => animationDelay;
            set => animationDelay = value >= 0 ? value : 0;
        }

        public Color FillColor
        {
            get => _fillColor;
            set => _fillColor = value;
        }

        public void InitializeData(PictureBox picCanvas)
        {
            picCanvas?.Refresh();
            _ordinal = 1;
        }

        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas)
        {
            if (_canvas == null)
            {
                return;
            }

            Color targetColor = _canvas.GetPixel(x, y);
            await Task.Run(() => FloodFillRecursive(x, y, targetColor, picCanvas));
        }

        private void FloodFillRecursive(int x, int y, Color targetColor, PictureBox picCanvas)
        {
            if (x < 0 || y < 0 || x >= _canvas.Width || y >= _canvas.Height)
                return;

            if (!ColorsMatch(_canvas.GetPixel(x, y), targetColor) ||
                ColorsMatch(_canvas.GetPixel(x, y), _fillColor))
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

        private bool ColorsMatch(Color a, Color b)
        {
            return a.R == b.R && a.G == b.G && a.B == b.B;
        }

        public void PlotShapes(PictureBox picCanvas)
        {
            _canvas = new Bitmap(picCanvas.Width, picCanvas.Height);

            BresenhamCircle bresenhamCircle = new BresenhamCircle();
            bresenhamCircle.Draw(picCanvas);
            picCanvas.Image = _canvas;
        }
       
    }
}

