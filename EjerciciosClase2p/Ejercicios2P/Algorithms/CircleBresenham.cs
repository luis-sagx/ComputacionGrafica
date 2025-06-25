using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios2P.Domain.Models;
using Ejercicios2P.Models;

namespace Ejercicios2P.DrawCircle
{
    public class CirculoBresenham : AlgorithmCalculator
    {
        public Point2D Center { get; private set; } = new Point2D();
        public int Radius { get; private set; }

        public void ReadData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadius)
        {
            if (!int.TryParse(txtCenterX.Text, out int centerX) || centerX < -100 || centerX > 100)
            {
                MessageBox.Show("Enter a valid integer between -100 and 100 for X coordinate", "Error");
                txtCenterX.Focus();
                txtCenterX.SelectAll();
                return;
            }

            if (!int.TryParse(txtCenterY.Text, out int centerY) || centerY < -100 || centerY > 100)
            {
                MessageBox.Show("Enter a valid integer between -100 and 100 for Y coordinate", "Error");
                txtCenterY.Focus();
                txtCenterY.SelectAll();
                return;
            }

            if (!int.TryParse(txtRadius.Text, out int radius) || radius < 1 || radius > 150)
            {
                MessageBox.Show("Enter a positive integer between 1 and 150 for radius", "Error");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            Center.X = centerX;
            Center.Y = centerY;
            Radius = radius;
        }

        public void InitializeData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadius,
                                  PictureBox picCanvas, DataGridView dgv = null)
        {
            Center = new Point2D();
            Radius = 0;
            txtCenterX.Text = txtCenterY.Text = txtRadius.Text = "";
            txtCenterX.Focus();
            picCanvas.Refresh();
            dgv?.Rows.Clear();
        }

        public override void Draw(PictureBox picCanvas, DataGridView dgv = null)
        {
            InitializeDrawingTools(picCanvas, Color.Blue);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            DrawAxes(picCanvas, centerX, centerY);

            int x = 0;
            int y = Radius;
            int p = 1 - Radius;
            int step = 0;

            DrawSymmetricPointsAnimated(x, y, centerX, centerY, dgv, step, p);
            step++;

            while (x < y)
            {
                x++;
                p += (p < 0) ? 2 * x + 1 : 2 * (x - y--) + 1;
                AnimationPause();
                DrawSymmetricPointsAnimated(x, y, centerX, centerY, dgv, step++, p);
            }
        }

        private void DrawSymmetricPointsAnimated(int x, int y, int centerX, int centerY, DataGridView dgv, int step, int p)
        {
            int cx = centerX + Center.X;
            int cy = centerY - Center.Y;

            var points = new List<Point>
            {
                new Point(cx + x, cy + y),
                new Point(cx - x, cy + y),
                new Point(cx + x, cy - y),
                new Point(cx - x, cy - y),
                new Point(cx + y, cy + x),
                new Point(cx - y, cy + x),
                new Point(cx + y, cy - x),
                new Point(cx - y, cy - x)
            };

            foreach (var point in points)
            {
                DrawPixel(point.X, point.Y);
            }

            dgv?.Rows.Add(step, x, y, p);
        }
    }
}


