using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2P.Utils
{
    public class PolygonGenerator
    {
        public const int DefaultRadius = 40; // Tamaño fijo del polígono

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
    }
}
