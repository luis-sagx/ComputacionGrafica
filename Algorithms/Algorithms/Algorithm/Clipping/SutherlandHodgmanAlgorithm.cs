using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Domain.Abstract;

namespace Algorithms.Algorithm
{
    public class SutherlandHodgmanAlgorithm : ClippingAlgorithm
    {
        public SutherlandHodgmanAlgorithm(Rectangle clipWindow) : base(clipWindow) { }

        public override bool ClipLine(Point start, Point end, out Point clippedStart, out Point clippedEnd)
        {
            clippedStart = Point.Empty;
            clippedEnd = Point.Empty;
            return false; // No aplica
        }

        public override List<Point> ClipPolygon(List<Point> polygon)
        {
            var outputList = new List<Point>(polygon);
            Point[] clipEdges = {
            new Point(ClipWindow.Left, ClipWindow.Top),
            new Point(ClipWindow.Right, ClipWindow.Top),
            new Point(ClipWindow.Right, ClipWindow.Bottom),
            new Point(ClipWindow.Left, ClipWindow.Bottom)
        };

            for (int i = 0; i < 4; i++)
            {
                var edgeStart = clipEdges[i];
                var edgeEnd = clipEdges[(i + 1) % 4];
                var inputList = new List<Point>(outputList);
                outputList.Clear();

                Point? prev = inputList.Last();

                foreach (var curr in inputList)
                {
                    if (IsInside(curr, edgeStart, edgeEnd))
                    {
                        if (!IsInside(prev.Value, edgeStart, edgeEnd))
                            outputList.Add(Intersect(prev.Value, curr, edgeStart, edgeEnd));
                        outputList.Add(curr);
                    }
                    else if (IsInside(prev.Value, edgeStart, edgeEnd))
                    {
                        outputList.Add(Intersect(prev.Value, curr, edgeStart, edgeEnd));
                    }

                    prev = curr;
                }
            }

            return outputList;
        }

        private bool IsInside(Point p, Point a, Point b)
        {
            return (b.X - a.X) * (p.Y - a.Y) - (b.Y - a.Y) * (p.X - a.X) >= 0;
        }

        private Point Intersect(Point p1, Point p2, Point a, Point b)
        {
            float A1 = p2.Y - p1.Y;
            float B1 = p1.X - p2.X;
            float C1 = A1 * p1.X + B1 * p1.Y;

            float A2 = b.Y - a.Y;
            float B2 = a.X - b.X;
            float C2 = A2 * a.X + B2 * a.Y;

            float delta = A1 * B2 - A2 * B1;
            if (delta == 0) return p1;

            float x = (B2 * C1 - B1 * C2) / delta;
            float y = (A1 * C2 - A2 * C1) / delta;

            return new Point((int)x, (int)y);
        }
    }

}
