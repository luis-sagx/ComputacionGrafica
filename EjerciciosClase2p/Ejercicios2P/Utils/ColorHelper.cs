using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2P.Utils
{
    internal class ColorHelper
    {
        public static bool ColorsMatch(Color a, Color b)
        {
            return a.ToArgb() == b.ToArgb();
        }
    }
}
