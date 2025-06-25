using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2.Algorithms
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
        private int sides;

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

        public void ReadData(TextBox txtSides)
        {
            sides = 0;
            if (!int.TryParse(txtSides.Text, out sides) || sides < 3)
            {
                MessageBox.Show("Ingrese un número entero mayor o igual a 3", "Error");
                txtSides.Focus();
                txtSides.Clear();
                throw new ArgumentException("Número de lados inválido");
            }
        }

        public void InitializeData(TextBox txtSides, PictureBox picCanvas, DataGridView dgv)
        {
            txtSides.Text = "";
            txtSides.Focus();
            dgv?.Rows.Clear();
            picCanvas?.Refresh();
            _ordinal = 1;
        }

        private void AnimationPause()
        {
            Application.DoEvents();
            Thread.Sleep(animationDelay);
        }

        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas, DataGridView dgv)
        {
            if (_canvas == null)
            {
                MessageBox.Show("Primero dibuje la figura.");
                return;
            }

            Color targetColor = _canvas.GetPixel(x, y);
            await Task.Run(() => FloodFillRecursive(x, y, targetColor, picCanvas, dgv));
        }

        private void FloodFillRecursive(int x, int y, Color targetColor, PictureBox picCanvas, DataGridView dgv)
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
                dgv?.Rows.Add(_ordinal++, x, y);
            }));

            Thread.Sleep(AnimationDelay);

            FloodFillRecursive(x, y - 1, targetColor, picCanvas, dgv);
            FloodFillRecursive(x + 1, y, targetColor, picCanvas, dgv);
            FloodFillRecursive(x, y + 1, targetColor, picCanvas, dgv);
            FloodFillRecursive(x - 1, y, targetColor, picCanvas, dgv);
        }

        private bool ColorsMatch(Color a, Color b)
        {
            return a.R == b.R && a.G == b.G && a.B == b.B;
        }

        public void PlotPolygon(int sides, PictureBox picCanvas)
        {
            _canvas = new Bitmap(picCanvas.Width, picCanvas.Height);
            var polygonPoints = GenerateCenteredPolygon(sides, picCanvas.Size);

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

        private PointF[] GenerateCenteredPolygon(int sides, Size canvasSize)
        {
            PointF[] points = new PointF[sides];
            float radius = Math.Min(canvasSize.Width, canvasSize.Height) / 3;
            float centerX = canvasSize.Width / 2;
            float centerY = canvasSize.Height / 2;

            for (int i = 0; i < sides; i++)
            {
                float angle = (float)(2 * Math.PI * i / sides);
                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle),
                    centerY + radius * (float)Math.Sin(angle));
            }

            return points;
        }
    }
}
