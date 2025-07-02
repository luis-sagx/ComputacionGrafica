using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Domain.Abstract;

namespace Algorithms.Algorithm.Fill
{
    public class FillIterativeAlgorithm : FillAlgorithm
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
            await Task.Run(() => FloodFillIterative(x, y, targetColor, picCanvas, token));
        }

        private void FloodFillIterative(int x, int y, Color targetColor, PictureBox picCanvas, CancellationToken token)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                if (token.IsCancellationRequested)
                    return;

                Point pt = stack.Pop();
                if (!IsValidPixel(pt.X, pt.Y)) continue;

                Color current = _canvas.GetPixel(pt.X, pt.Y);
                if (!ShouldFill(current, targetColor)) continue;

                _canvas.SetPixel(pt.X, pt.Y, _fillColor);
                picCanvas.Invoke((MethodInvoker)(() => picCanvas.Image = _canvas));
                Thread.Sleep(AnimationDelay);

                stack.Push(new Point(pt.X + 1, pt.Y));
                stack.Push(new Point(pt.X - 1, pt.Y));
                stack.Push(new Point(pt.X, pt.Y + 1));
                stack.Push(new Point(pt.X, pt.Y - 1));
            }
        }

    }
}