using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Domain.Abstract;

namespace Algorithms.Algorithm
{
    public class CohenSutherlandAlgorithm : ClippingAlgorithm
    {
        private const byte INSIDE = 0, LEFT = 1, RIGHT = 2, BOTTOM = 4, TOP = 8;

        public CohenSutherlandAlgorithm(Rectangle clipWindow) : base(clipWindow) { }

        private byte ComputeOutCode(Point p)
        {
            byte code = INSIDE;
            if (p.X < ClipWindow.Left) code |= LEFT;
            else if (p.X > ClipWindow.Right) code |= RIGHT;
            if (p.Y < ClipWindow.Top) code |= TOP;
            else if (p.Y > ClipWindow.Bottom) code |= BOTTOM;
            return code;
        }

        public override bool ClipLine(Point start, Point end, out Point clippedStart, out Point clippedEnd)
        {
            byte code1 = ComputeOutCode(start);
            byte code2 = ComputeOutCode(end);

            clippedStart = start;
            clippedEnd = end;

            bool accept = false;

            while (true)
            {
                if ((code1 | code2) == 0)
                {
                    accept = true;
                    break;
                }
                else if ((code1 & code2) != 0)
                {
                    break;
                }

                byte outCode = (code1 != 0) ? code1 : code2;
                int x = 0, y = 0;

                if ((outCode & TOP) != 0)
                {
                    x = start.X + (end.X - start.X) * (ClipWindow.Top - start.Y) / (end.Y - start.Y);
                    y = ClipWindow.Top;
                }
                else if ((outCode & BOTTOM) != 0)
                {
                    x = start.X + (end.X - start.X) * (ClipWindow.Bottom - start.Y) / (end.Y - start.Y);
                    y = ClipWindow.Bottom;
                }
                else if ((outCode & RIGHT) != 0)
                {
                    y = start.Y + (end.Y - start.Y) * (ClipWindow.Right - start.X) / (end.X - start.X);
                    x = ClipWindow.Right;
                }
                else if ((outCode & LEFT) != 0)
                {
                    y = start.Y + (end.Y - start.Y) * (ClipWindow.Left - start.X) / (end.X - start.X);
                    x = ClipWindow.Left;
                }

                if (outCode == code1)
                {
                    start = new Point(x, y);
                    code1 = ComputeOutCode(start);
                    clippedStart = start;
                }
                else
                {
                    end = new Point(x, y);
                    code2 = ComputeOutCode(end);
                    clippedEnd = end;
                }
            }

            return accept;
        }

        public override List<Point> ClipPolygon(List<Point> polygon) => null; // No aplica
    }

}
