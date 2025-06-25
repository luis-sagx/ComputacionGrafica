using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Domain.Abstract
{
    public abstract class ClippingAlgorithm
    {
        public Rectangle ClipWindow { get; set; }

        protected ClippingAlgorithm(Rectangle clipWindow)
        {
            ClipWindow = clipWindow;
        }

        public abstract bool ClipLine(Point start, Point end, out Point clippedStart, out Point clippedEnd);

        public abstract List<Point> ClipPolygon(List<Point> polygon);
    }
}
