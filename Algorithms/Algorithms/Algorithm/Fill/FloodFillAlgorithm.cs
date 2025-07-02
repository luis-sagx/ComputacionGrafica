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
    public class FloodFillAlgorithm : FillAlgorithm
    {
        public override void Draw(PictureBox picCanvas)
        {
            throw new NotImplementedException();
        }

        public override async Task FillAsync(int x, int y, PictureBox picCanvas, CancellationToken token)
        {
            if (_canvas == null)
            {
                MessageBox.Show("First, draw the shape.", "Warning");
                return;
            }

            Color targetColor = _canvas.GetPixel(x, y);
            await Task.Run(() => FloodFillRecursive(x, y, targetColor, picCanvas, token)); 
        }

        private void FloodFillRecursive(int x, int y, Color targetColor, PictureBox picCanvas, CancellationToken token)
        {
            if (!IsValidPixel(x, y)) return;

            if (token.IsCancellationRequested)
                return;

            var currentColor = _canvas.GetPixel(x, y);
            if (!ShouldFill(currentColor, targetColor)) return;

            _canvas.SetPixel(x, y, _fillColor);
            picCanvas.Invoke((MethodInvoker)(() => picCanvas.Image = _canvas));
            Thread.Sleep(AnimationDelay);

            FloodFillRecursive(x, y - 1, targetColor, picCanvas, token);
            FloodFillRecursive(x + 1, y, targetColor, picCanvas, token);
            FloodFillRecursive(x, y + 1, targetColor, picCanvas, token);
            FloodFillRecursive(x - 1, y, targetColor, picCanvas, token);
        }
    }
}