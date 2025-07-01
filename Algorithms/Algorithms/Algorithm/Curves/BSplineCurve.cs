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
    public class BSplineCurve : ICurveAlgorithm
    {
        public List<PointF> ControlPoints { get; private set; } = new List<PointF>();
        public List<PointF> GeneratedCurve { get; private set; } = new List<PointF>();

        public float StepSize { get; set; } = 0.01f;
        public int Degree { get; set; } = 3;

        private float[] _knotVector;

        public void AddPoint(PointF point) => ControlPoints.Add(point);

        public void GenerateCurve()
        {
            GeneratedCurve.Clear();

            if (ControlPoints.Count < 2) return;

            int actualDegree = Math.Min(Degree, ControlPoints.Count - 1);
            if (actualDegree < 1) actualDegree = 1;

            GenerateKnotVector(actualDegree);

            float tStart = _knotVector[actualDegree];
            float tEnd = _knotVector[ControlPoints.Count];

            if (tEnd <= tStart) return;

            int steps = 100;
            for (int i = 0; i <= steps; i++)
            {
                float t = tStart + (tEnd - tStart) * i / steps;

                if (t < tStart) t = tStart;
                if (t > tEnd) t = tEnd;

                var point = EvaluateBSpline(t, actualDegree);

                if (!float.IsNaN(point.X) && !float.IsNaN(point.Y) &&
                    !float.IsInfinity(point.X) && !float.IsInfinity(point.Y))
                {
                    GeneratedCurve.Add(point);
                }
            }
        }

        private void GenerateKnotVector(int degree)
        {
            int n = ControlPoints.Count;
            int m = n + degree + 1;
            _knotVector = new float[m];

            for (int i = 0; i < m; i++)
            {
                if (i <= degree)
                    _knotVector[i] = 0;
                else if (i >= n)
                    _knotVector[i] = n - degree;
                else
                    _knotVector[i] = i - degree;
            }
        }

        private PointF EvaluateBSpline(float t, int degree)
        {
            int n = ControlPoints.Count;
            float x = 0, y = 0;
            float weightSum = 0;

            for (int i = 0; i < n; i++)
            {
                float basis = BasisFunction(i, degree, t);
                if (basis > 0) // Solo considerar bases con contribución positiva
                {
                    x += ControlPoints[i].X * basis;
                    y += ControlPoints[i].Y * basis;
                    weightSum += basis;
                }
            }

            if (weightSum > 0.001f)
            {
                return new PointF(x, y);
            }

            return ControlPoints[0];
        }

        private float BasisFunction(int i, int p, float t)
        {
            if (p == 0)
            {
                if (i >= _knotVector.Length - 1) return 0;

                if (i == ControlPoints.Count - 1 && Math.Abs(t - _knotVector[i + 1]) < 1e-10)
                    return 1.0f;

                return (t >= _knotVector[i] && t < _knotVector[i + 1]) ? 1.0f : 0.0f;
            }

            float result = 0.0f;

            if (i + p >= _knotVector.Length || i + p + 1 >= _knotVector.Length)
                return 0;

            float denom1 = _knotVector[i + p] - _knotVector[i];
            if (Math.Abs(denom1) > 1e-10)
            {
                result += (t - _knotVector[i]) / denom1 * BasisFunction(i, p - 1, t);
            }

            float denom2 = _knotVector[i + p + 1] - _knotVector[i + 1];
            if (Math.Abs(denom2) > 1e-10)
            {
                result += (_knotVector[i + p + 1] - t) / denom2 * BasisFunction(i + 1, p - 1, t);
            }

            return result;
        }
    }

}