using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Domain.Interface
{
    public interface ICurveAlgorithm
    {
        List<PointF> ControlPoints { get; }
        List<PointF> GeneratedCurve { get; }

        void AddPoint(PointF point);
        void GenerateCurve();
    }



}
