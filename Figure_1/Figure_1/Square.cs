using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure_1
{
    public class Square
    {
        private float mSize;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;  //Const scale factor (Zooom In/ Zoom Out)
        private Pen mPen;

        public Square()
        {
            mSize = mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtSize)
        {
            try
            {
                mSize = float.Parse(txtSize.Text);
            }
            catch
            {
                MessageBox.Show("Invalid inputs", "Error Messaje");
            }
        }

        public void PerimeterRectangle()
        {
            mPerimeter = 4 * mSize;
        }

        public void AreaRectangle()
        {
            mArea = mSize * mSize;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSize, TextBox txtPerimeter, TextBox txtArea, PictureBox picCavas)
        {
            mSize = mPerimeter = mArea = 0.0f;

            txtSize.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            txtSize.Focus();
            picCavas.Refresh();
        }

        public void PlotShape(PictureBox picCavas)
        {
            mGraph = picCavas.CreateGraphics();
            mPen = new Pen(Color.Red, 3); //(Color, ancho en px)

            mGraph.DrawRectangle(mPen, 0, 0, mSize * SF, mSize * SF);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
