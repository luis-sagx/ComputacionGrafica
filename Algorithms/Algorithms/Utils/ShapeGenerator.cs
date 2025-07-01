using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Utils
{
    public class ShapeGenerator
    {
        public const int DefaultRadius = 50; // Tamaño fijo

        public static List<PointF> GenerateCenteredPolygon(int sides, Size canvasSize)
        {
            Point center = new Point(canvasSize.Width / 2, canvasSize.Height / 2);
            return GenerateRegularPolygon(center, DefaultRadius, sides);
        }

        private static List<PointF> GenerateRegularPolygon(Point center, int radius, int sides)
        {
            var points = new List<PointF>();
            double angleStep = 2 * Math.PI / sides;

            for (int i = 0; i < sides; i++)
            {
                double angle = i * angleStep;
                float x = center.X + (float)(radius * Math.Cos(angle));
                float y = center.Y + (float)(radius * Math.Sin(angle));
                points.Add(new PointF(x, y));
            }

            return points;
        }

        public static List<PointF> GenerateStar(int points, Size canvasSize)
        {
            var center = new Point(canvasSize.Width / 2, canvasSize.Height / 2);
            var result = new List<PointF>();
            int doublePoints = points * 2;
            double angleStep = Math.PI / points;
            int outerRadius = DefaultRadius;
            int innerRadius = DefaultRadius / 2;

            for (int i = 0; i < doublePoints; i++)
            {
                double angle = i * angleStep;
                int radius = (i % 2 == 0) ? outerRadius : innerRadius;

                float x = center.X + (float)(radius * Math.Cos(angle));
                float y = center.Y + (float)(radius * Math.Sin(angle));
                result.Add(new PointF(x, y));
            }

            return result;
        }

    }
}
