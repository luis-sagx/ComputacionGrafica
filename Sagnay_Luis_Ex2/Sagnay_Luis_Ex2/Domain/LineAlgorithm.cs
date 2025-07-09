using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagnay_Luis_Ex2.Domain
{
    public abstract class LineAlgorithm : AlgorithmCalculator
    {
        public Point StartPoint = new Point();
        public Point EndPoint = new Point();
    }
}
