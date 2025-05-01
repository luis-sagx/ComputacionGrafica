using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure_1
{
    public class Rectangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;  //Const scale factor (Zooom In/ Zoom Out)
        private Pen mPen;

        public Rectangle()
        {
            mWidth = mHeight = mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtWidth, TextBox txtHeigth)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeigth.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso invalido...", "Mensaje de error");
            }
        }

        public void PerimeterRectangle()
        {
            mPerimeter = 2 * mWidth + 2 * mHeight;
        }

        public void AreaRectangle()
        {
            mArea = mWidth * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtWidth, TextBox txtHeigth, TextBox txtPerimeter, TextBox txtArea, PictureBox picCavas)
        {
            mWidth = mHeight = mPerimeter = mArea = 0.0f;

            txtWidth.Text = ""; txtHeigth.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtWidth.Focus();
            picCavas.Refresh();
        }

        public void PlotShape(PictureBox picCavas)
        {
            mGraph = picCavas.CreateGraphics();
            mPen = new Pen(Color.Red, 3); //(Color, ancho en px)

            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
