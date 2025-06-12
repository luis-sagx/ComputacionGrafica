using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios2P.Bresenham
{
    public class AlgoritmoBresenham
    {
        private int xi;
        private int yi;
        private int x;
        private int y;
        private Graphics mGraph;
        private Pen mPen;

        public AlgoritmoBresenham()
        {
            xi = yi = x = y = 0;
        }

        public void ReadData(TextBox txtPuntoxi, TextBox txtPuntoyi, TextBox txtPuntox, TextBox txtPuntoy)
        {
            try
            {
                xi = int.Parse(txtPuntoxi.Text);
                yi = int.Parse(txtPuntoyi.Text);
                x = int.Parse(txtPuntox.Text);
                y = int.Parse(txtPuntoy.Text);
            }
            catch
            {
                MessageBox.Show("Invalid inputs", "Error Message");
            }
        }

        public void InitializeData(TextBox txtPuntoxi, TextBox txtPuntoyi, TextBox txtPuntox, TextBox txtPuntoy, PictureBox picCanvas)
        {
            xi = yi = x = y = 0;

            txtPuntoxi.Text = ""; txtPuntox.Text = "";
            txtPuntoyi.Text = ""; txtPuntoy.Text = "";

            txtPuntoxi.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 1);

            int dx = x - xi;
            int dy = y - yi;

            int x0 = xi;
            int y0 = yi;
            int x1 = x;
            int y1 = y;

            int absDx = Math.Abs(dx);
            int absDy = Math.Abs(dy);

            int sx = dx >= 0 ? 1 : -1;
            int sy = dy >= 0 ? 1 : -1;

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            int px = x0;
            int py = y0;

            // Decisión entre caso dominante en X o en Y
            if (absDx > absDy)
            {
                int p = 2 * absDy - absDx;
                for (int i = 0; i <= absDx; i++)
                {
                    int xCanvas = centerX + px;
                    int yCanvas = centerY - py;
                    mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                    px += sx;
                    if (p < 0)
                    {
                        p += 2 * absDy;
                    }
                    else
                    {
                        py += sy;
                        p += 2 * absDy - 2 * absDx;
                    }
                }
            }
            else
            {
                int p = 2 * absDx - absDy;
                for (int i = 0; i <= absDy; i++)
                {
                    int xCanvas = centerX + px;
                    int yCanvas = centerY - py;
                    mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                    py += sy;
                    if (p < 0)
                    {
                        p += 2 * absDx;
                    }
                    else
                    {
                        px += sx;
                        p += 2 * absDx - 2 * absDy;
                    }
                }
            }

            Pen ejePen = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY); 
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height); 
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }

}
