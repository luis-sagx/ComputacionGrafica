using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios2P.DDA
{
    public class AlgoritmoDDA
    {
        private int xi;
        private int yi;
        private int x;
        private int y;
        private Graphics mGraph;
        private Pen mPen;

        public AlgoritmoDDA()
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
            mPen = new Pen(Color.Green, 1);

            int dx = x - xi;
            int dy = y - yi;

            float m = dx != 0 ? (float)dy / dx : float.PositiveInfinity;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xk = xi;
            float yk = yi;

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            for (int i = 0; i <= steps; i++)
            {
                int xCanvas = (int)Math.Round(centerX + xk);
                int yCanvas = (int)Math.Round(centerY - yk); // Se invierte Y

                mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                if (Math.Abs(m) <= 1)
                {
                    if (dx >= 0)
                    {
                        xk += 1;
                        yk += m;
                    }
                    else
                    {
                        xk -= 1;
                        yk -= m;
                    }
                }
                else
                {
                    if (dy >= 0)
                    {
                        yk += 1;
                        xk += 1 / m;
                    }
                    else
                    {
                        yk -= 1;
                        xk -= 1 / m;
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
