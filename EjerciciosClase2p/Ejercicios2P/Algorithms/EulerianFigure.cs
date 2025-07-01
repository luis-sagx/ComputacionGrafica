using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios2P.DDA;
using System.Windows.Forms;

namespace Ejercicios2P.Algorithms
{
    public class EulerianFigure : DDAAlgorithm
    {
        private List<PointF> vertices;
        private List<int> path; // orden secuencial de vértices

        public EulerianFigure(List<PointF> vertices, List<int> path)
        {
            this.vertices = vertices;
            this.path = path;
        }

        public void Draw(PictureBox picCanvas)
        {
            InitializeDrawingTools(picCanvas, Color.DarkBlue);
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            DrawAxes(picCanvas, centerX, centerY);

            for (int i = 0; i < path.Count - 1; i++)
            {
                PointF p1 = vertices[path[i]];
                PointF p2 = vertices[path[i + 1]];
                DrawLineDDA(p1, p2, centerX, centerY);
            }
        }

        private void DrawLineDDA(PointF p1, PointF p2, int centerX, int centerY)
        {
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            int steps = (int)Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xk = p1.X;
            float yk = p1.Y;

            float xInc = dx / steps;
            float yInc = dy / steps;

            for (int i = 0; i <= steps; i++)
            {
                int xCanvas = (int)Math.Round(centerX + xk);
                int yCanvas = (int)Math.Round(centerY - yk);

                DrawPixel(xCanvas, yCanvas);
                AnimationPause();

                xk += xInc;
                yk += yInc;
            }
        }
    }


}