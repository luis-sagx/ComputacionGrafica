using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public abstract class Shape
    {
        protected float mArea;
        protected float mPerimeter;
        protected float SF = 20f; 
        protected Graphics mGraph;
        protected Pen mPen;
        protected bool isValid = true;

        protected Shape() 
        {
            mArea = 0.0f;
            mPerimeter = 0.0f;
        }
        public abstract void ReadData(params TextBox[] inputs);

        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

        public abstract void PlotShape(PictureBox canvas);

        public virtual void InitializeData(TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mArea = mPerimeter = 0.0f;
            txtArea.Text = txtPerimeter.Text = "";
            picCanvas.Refresh();
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }

}
