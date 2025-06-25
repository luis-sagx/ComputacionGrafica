using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2P.Algorithms
{
    public class SutherlandHodgmanAlgorithm
    {
        public static List<Point> ClipPolygon(List<Point> polygon, Rectangle clippingRectangle)
        {
            polygon.Add(polygon[0]);
            List<Point> outputList = new List<Point>(polygon);
            List<Point> inputList = new List<Point>(polygon);

            Point[] edges = new Point[]
            {
                new Point(clippingRectangle.Left, clippingRectangle.Top),  
                new Point(clippingRectangle.Right, clippingRectangle.Top),   
                new Point(clippingRectangle.Right, clippingRectangle.Bottom),
                new Point(clippingRectangle.Left, clippingRectangle.Bottom) 
            };

            for (int i = 0; i < edges.Length; i++)
            {
                Point edgeStart = edges[i];
                Point edgeEnd = edges[(i + 1) % edges.Length];

                outputList.Clear();
                Point? previousVertex = null;

                foreach (Point currentVertex in inputList)
                {
                    if (IsInside(currentVertex, edgeStart, edgeEnd))
                    {
                        if (previousVertex != null && !IsInside(previousVertex.Value, edgeStart, edgeEnd))
                        {
                            outputList.Add(Intersect(previousVertex.Value, currentVertex, edgeStart, edgeEnd));
                        }
                        outputList.Add(currentVertex);
                    }
                    else if (previousVertex != null && IsInside(previousVertex.Value, edgeStart, edgeEnd))
                    {
                        outputList.Add(Intersect(previousVertex.Value, currentVertex, edgeStart, edgeEnd));
                    }

                    previousVertex = currentVertex;
                }

                inputList = new List<Point>(outputList);
            }

            return outputList;
        }

        private static bool IsInside(Point vertex, Point edgeStart, Point edgeEnd)
        {
            return (edgeEnd.X - edgeStart.X) * (vertex.Y - edgeStart.Y)
                 - (edgeEnd.Y - edgeStart.Y) * (vertex.X - edgeStart.X) >= 0;
        }

        private static Point Intersect(Point p1, Point p2, Point edgeStart, Point edgeEnd)
        {
            float a1 = p2.Y - p1.Y;
            float b1 = p1.X - p2.X;
            float c1 = a1 * p1.X + b1 * p1.Y;

            float a2 = edgeEnd.Y - edgeStart.Y;
            float b2 = edgeStart.X - edgeEnd.X;
            float c2 = a2 * edgeStart.X + b2 * edgeStart.Y;

            float delta = a1 * b2 - a2 * b1;
            if (delta == 0)
                return p1; 

            float x = (b2 * c1 - b1 * c2) / delta;
            float y = (a1 * c2 - a2 * c1) / delta;

            return new Point((int)x, (int)y);
        }
    }
}

