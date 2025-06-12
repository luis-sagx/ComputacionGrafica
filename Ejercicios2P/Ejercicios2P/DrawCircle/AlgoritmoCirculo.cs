using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios2P.DrawCircle
{
    public class AlgoritmoCirculo
    {
        private int xc;
        private int yc;
        private int radio;
        private Graphics mGraph;
        private Pen mPen;

        public AlgoritmoCirculo()
        {
            xc = yc = radio = 0;
        }

        public void ReadData(TextBox txtCentroX, TextBox txtCentroY, TextBox txtRadio)
        {
            try
            {
                xc = int.Parse(txtCentroX.Text);
                yc = int.Parse(txtCentroY.Text);
                radio = int.Parse(txtRadio.Text);
            }
            catch
            {
                MessageBox.Show("Invalid inputs", "Error Message");
            }
        }

        public void InitializeData(TextBox txtCentroX, TextBox txtCentroY, TextBox txtRadio, PictureBox picCanvas)
        {
            xc = yc = radio = 0;

            txtCentroX.Text = ""; txtCentroY.Text = ""; txtRadio.Text = "";
            txtCentroX.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 1);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            int x = 0;
            int y = radio;
            int p = 1 - radio;

            DrawSymmetricPoints(x, y, centerX, centerY);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                DrawSymmetricPoints(x, y, centerX, centerY);
            }

            Pen ejePen = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY); 
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
        }

        private void DrawSymmetricPoints(int x, int y, int centerX, int centerY)
        {
            int cx = centerX + xc;
            int cy = centerY - yc;

            DrawPixel(cx + x, cy + y);
            DrawPixel(cx - x, cy + y);
            DrawPixel(cx + x, cy - y);
            DrawPixel(cx - x, cy - y);
            DrawPixel(cx + y, cy + x);
            DrawPixel(cx - y, cy + x);
            DrawPixel(cx + y, cy - x);
            DrawPixel(cx - y, cy - x);
        }

        private void DrawPixel(int x, int y)
        {
            mGraph.DrawRectangle(mPen, x, y, 1, 1);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }

}
