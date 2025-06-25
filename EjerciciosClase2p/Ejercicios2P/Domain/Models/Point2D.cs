using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2P.Domain.Models
{
    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
