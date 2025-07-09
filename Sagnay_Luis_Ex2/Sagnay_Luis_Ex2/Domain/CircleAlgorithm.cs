using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagnay_Luis_Ex2.Domain
{
    public abstract class CircleAlgorithm : AlgorithmCalculator
    {
        public Point Centro = new Point();
        public Point PuntoRadio = new Point();

        protected int CalcularRadio()
        {
            int dx = PuntoRadio.X - Centro.X;
            int dy = PuntoRadio.Y - Centro.Y;
            return (int)Math.Round(Math.Sqrt(dx * dx + dy * dy));
        }
    }
}
