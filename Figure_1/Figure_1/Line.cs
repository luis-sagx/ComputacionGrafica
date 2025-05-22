using System.Collections.Generic;
using System.Drawing;

namespace Figure_1
{
    public class Line
    {
        private List<PointF> points;

        public Line()
        {
            points = new List<PointF>() { new PointF(0, 0) };
        }

        public void AddPoint(PointF point)
        {
            points.Add(point);
        }

        public void DrawAll(Graphics g)
        {
            if (points.Count < 2)
                return;

            using (Pen pen = new Pen(Color.DarkBlue, 2))
            using (Brush brush = new SolidBrush(Color.Red))
            {
                for (int i = 0; i < points.Count; i++)
                {
                    g.FillEllipse(brush, points[i].X - 2, points[i].Y - 2, 5, 5);

                    if (i < points.Count - 1)
                        g.DrawLine(pen, points[i], points[i + 1]);
                }
            }
        }

        public void Clear()
        {
            points.Clear();
        }
    }
}
