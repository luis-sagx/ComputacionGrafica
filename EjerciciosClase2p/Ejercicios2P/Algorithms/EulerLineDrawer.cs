using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Ejercicios2P.Algorithms.Line;
using Ejercicios2P.Domain.Models;
using System.Windows.Forms;

namespace Ejercicios2P.Algorithms
{
    public class EulerLineDrawer : LineAlgorithm
    {
        private List<Point2D> Vertices = new List<Point2D>();
        private List<(int from, int to)> EulerPath = new List<(int, int)>();

        public void GeneratePolygonVertices(int centerX, int centerY, int radius, int sides)
        {
            Vertices.Clear();
            double angleStep = 2 * Math.PI / sides;

            for (int i = 0; i < sides; i++)
            {
                double angle = i * angleStep;
                int x = centerX + (int)(radius * Math.Cos(angle));
                int y = centerY - (int)(radius * Math.Sin(angle));
                Vertices.Add(new Point2D(x, y));
            }
        }

        public void SetEulerPath(List<(int from, int to)> path)
        {
            EulerPath = path;
        }

        public override void Draw(PictureBox picCanvas, DataGridView dgv = null)
        {
            InitializeDrawingTools(picCanvas, Color.MediumVioletRed);
            DrawAxes(picCanvas, picCanvas.Width / 2, picCanvas.Height / 2);

            for (int i = 0; i < EulerPath.Count; i++)
            {
                var from = Vertices[EulerPath[i].from];
                var to = Vertices[EulerPath[i].to];

                StartPoint = from;
                EndPoint = to;

                DrawDDA(picCanvas, dgv, i);
            }
        }

        private void DrawDDA(PictureBox picCanvas, DataGridView dgv, int segmentIndex)
        {
            int dx = EndPoint.X - StartPoint.X;
            int dy = EndPoint.Y - StartPoint.Y;
            float m = dx != 0 ? (float)dy / dx : float.PositiveInfinity;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            float xk = StartPoint.X;
            float yk = StartPoint.Y;

            for (int i = 0; i <= steps; i++)
            {
                DrawPixel((int)Math.Round(xk), (int)Math.Round(yk));
                dgv?.Rows.Add($"{segmentIndex}.{i}", Math.Round(xk, 2), Math.Round(yk, 2));
                AnimationPause();

                if (Math.Abs(m) <= 1)
                {
                    xk += (dx >= 0) ? 1 : -1;
                    yk += (dx >= 0) ? m : -m;
                }
                else
                {
                    yk += (dy >= 0) ? 1 : -1;
                    xk += (dy >= 0) ? 1 / m : -1 / m;
                }
            }
        }
    }

}
