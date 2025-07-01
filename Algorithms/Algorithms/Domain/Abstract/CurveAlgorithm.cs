using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Domain.Abstract
{
    public abstract class CurveAlgorithm
    {
        public abstract List<PointF> PuntosControl { get; }
        public abstract List<PointF> CurvaGenerada { get; }

        public abstract void AgregarPunto(PointF p);
        public abstract void GenerarCurva();
        public abstract void Resetear();
    }
}
