using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Domain.Abstract;
using System.Windows.Forms;
using Algorithms.Domain.Interface;

namespace Algorithms.Algorithm.Curves
{
    public class BezierCurve : ICurveAlgorithm
    {
        public List<PointF> ControlPoints { get; private set; } = new List<PointF>();
        public List<PointF> GeneratedCurve { get; private set; } = new List<PointF>();
        public float StepSize { get; set; } = 0.01f;

        public void AddPoint(PointF point) => ControlPoints.Add(point);

        public void GenerateCurve()
        {
            GeneratedCurve.Clear();
            if (ControlPoints.Count < 2) return;

            for (float t = 0; t <= 1; t += StepSize)
            {
                var p = DeCasteljau(ControlPoints, t);
                GeneratedCurve.Add(p);
            }
        }

        private PointF DeCasteljau(List<PointF> points, float t)
        {
            var temp = new List<PointF>(points);
            while (temp.Count > 1)
            {
                var next = new List<PointF>();
                for (int i = 0; i < temp.Count - 1; i++)
                {
                    next.Add(Lerp(temp[i], temp[i + 1], t));
                }
                temp = next;
            }
            return temp[0];
        }

        private PointF Lerp(PointF p1, PointF p2, float t)
        {
            return new PointF(
                p1.X + (p2.X - p1.X) * t,
                p1.Y + (p2.Y - p1.Y) * t
            );
        }
    }

}
