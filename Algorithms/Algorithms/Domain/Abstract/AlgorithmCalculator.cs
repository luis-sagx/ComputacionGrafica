using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Domain.Abstract
{
    public abstract class AlgorithmCalculator
    {
        protected Graphics mGraph;
        protected Pen mPen;
        protected int animationDelay = 80;

        public Color DrawingColor { get; set; } = Color.Black;
        public int AnimationDelay
        {
            get => animationDelay;
            set => animationDelay = value >= 0 ? value : 0;
        }

        public abstract void Draw(PictureBox picCanvas);

        public void DrawAxes(PictureBox picCanvas, int centerX, int centerY)
        {
            mGraph = picCanvas.CreateGraphics();
            Pen ejePen = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
        }

        protected void DrawPixel(int x, int y)
        {
            mGraph.DrawRectangle(mPen, x, y, 1, 1);
        }

        protected void InitializeDrawingTools(PictureBox picCanvas, Color? color = null)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(color ?? DrawingColor, 1);
        }

        protected void AnimationPause()
        {
            Application.DoEvents();
            Thread.Sleep(animationDelay);
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }

    }
}
