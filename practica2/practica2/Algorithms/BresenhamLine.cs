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
    public class BresenhamLine
    {
        private Graphics mGraph;
        private Pen mPen;
        private int animationDelay = 80;
        private int startX, startY, endX, endY;

        public int AnimationDelay
        {
            get => animationDelay;
            set => animationDelay = value >= 0 ? value : 0;
        }

        public void ReadData(TextBox txtStartX, TextBox txtStartY, TextBox txtEndX, TextBox txtEndY)
        {
            startX = startY = endX = endY = 0;

            try
            {
                startX = int.Parse(txtStartX.Text);
                startY = int.Parse(txtStartY.Text);
                endX = int.Parse(txtEndX.Text);
                endY = int.Parse(txtEndY.Text);

                if (Math.Abs(startX) > 150 || Math.Abs(startY) > 150 ||
                    Math.Abs(endX) > 150 || Math.Abs(endY) > 150)
                {
                    MessageBox.Show("Coordinates must be between -150 and 150", "Range error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStartX.Focus();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, Enter valid values", "Format error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStartX.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InitializeData(TextBox txtStartX, TextBox txtStartY, TextBox txtEndX, TextBox txtEndY,
                                  PictureBox picCanvas, DataGridView dgv = null)
        {
            txtStartX.Text = txtEndX.Text = "";
            txtStartY.Text = txtEndY.Text = "";
            txtStartX.Focus();
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
            mPen = new Pen(Color.Red, 1);
        }

        private void AnimationPause()
        {
            Application.DoEvents();
            Thread.Sleep(animationDelay);
        }

        public void Draw(PictureBox picCanvas, DataGridView dgv = null)
        {
            InitializeDrawingTools(picCanvas);

            int dx = endX - startX;
            int dy = endY - startY;
            int absDx = Math.Abs(dx);
            int absDy = Math.Abs(dy);
            int sx = dx >= 0 ? 1 : -1;
            int sy = dy >= 0 ? 1 : -1;
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            DrawAxes(picCanvas, centerX, centerY);

            bool isXMajor = absDx > absDy;
            int p = isXMajor ? 2 * absDy - absDx : 2 * absDx - absDy;
            int steps = isXMajor ? absDx : absDy;
            int px = startX;
            int py = startY;
            int step = 0;

            for (int i = 0; i <= steps; i++)
            {
                DrawPixel(centerX + px, centerY - py);
                dgv?.Rows.Add(step, px, py, p);
                AnimationPause();

                if (isXMajor)
                {
                    px += sx;
                    if (p < 0) p += 2 * absDy;
                    else { py += sy; p += 2 * (absDy - absDx); }
                }
                else
                {
                    py += sy;
                    if (p < 0) p += 2 * absDx;
                    else { px += sx; p += 2 * (absDx - absDy); }
                }
                step++;
            }
        }
    }
}
