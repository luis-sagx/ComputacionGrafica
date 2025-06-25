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
    public class BresenhamCircle
    {
        private Graphics mGraph;
        private Pen mPen;
        private int animationDelay = 80;
        private int centerX, centerY, radius;

        public int AnimationDelay
        {
            get => animationDelay;
            set => animationDelay = value >= 0 ? value : 0;
        }

        public void ReadData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadius)
        {
            centerX = centerY = radius = 0;

            if (!int.TryParse(txtCenterX.Text, out centerX) || centerX < -100 || centerX > 100)
            {
                MessageBox.Show("Enter a valid integer between -100 and 100 for X coordinate", "Error");
                txtCenterX.Focus();
                txtCenterX.SelectAll();
                return;
            }

            if (!int.TryParse(txtCenterY.Text, out centerY) || centerY < -100 || centerY > 100)
            {
                MessageBox.Show("Enter a valid integer between -100 and 100 for Y coordinate", "Error");
                txtCenterY.Focus();
                txtCenterY.SelectAll();
                return;
            }

            if (!int.TryParse(txtRadius.Text, out radius) || radius < 1 || radius > 150)
            {
                MessageBox.Show("Enter a positive integer between 1 and 150 for radius", "Error");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }
        }

        public void InitializeData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadius,
                                  PictureBox picCanvas, DataGridView dgv = null)
        {
            txtCenterX.Text = txtCenterY.Text = txtRadius.Text = "";
            txtCenterX.Focus();
            picCanvas.Refresh();
            dgv?.Rows.Clear();
        }

        private void DrawAxes(PictureBox picCanvas, int centerX, int centerY)
        {
            mGraph = picCanvas.CreateGraphics();
            Pen ejePen = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
        }

        private void DrawPixel(int x, int y)
        {
            mGraph.DrawRectangle(mPen, x, y, 1, 1);
        }

        private void InitializeDrawingTools(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Orange, 1);
        }

        private void AnimationPause()
        {
            Application.DoEvents();
            Thread.Sleep(animationDelay);
        }

        public void Draw(PictureBox picCanvas, DataGridView dgv = null)
        {
            InitializeDrawingTools(picCanvas);

            int canvasCenterX = picCanvas.Width / 2;
            int canvasCenterY = picCanvas.Height / 2;

            DrawAxes(picCanvas, canvasCenterX, canvasCenterY);

            int x = 0;
            int y = radius;
            int p = 1 - radius;
            int step = 0;

            DrawSymmetricPointsAnimated(x, y, canvasCenterX, canvasCenterY, dgv, step, p);
            step++;

            while (x < y)
            {
                x++;
                p += (p < 0) ? 2 * x + 1 : 2 * (x - y--) + 1;
                AnimationPause();
                DrawSymmetricPointsAnimated(x, y, canvasCenterX, canvasCenterY, dgv, step++, p);
            }
        }

        private void DrawSymmetricPointsAnimated(int x, int y, int canvasCenterX, int canvasCenterY, DataGridView dgv, int step, int p)
        {
            int cx = canvasCenterX + centerX;
            int cy = canvasCenterY - centerY;

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
