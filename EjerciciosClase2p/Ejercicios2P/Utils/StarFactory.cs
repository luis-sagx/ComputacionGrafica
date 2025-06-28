using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios2P.Algorithms;

namespace Ejercicios2P.Utils
{
    public static class StarFactory
    {
        public static List<PointF> GenerateRegularPolygon(int vertices, float radius)
        {
            var points = new List<PointF>();
            double angleStep = 2 * Math.PI / vertices;

            for (int i = 0; i < vertices; i++)
            {
                float x = radius * (float)Math.Cos(i * angleStep - Math.PI / 2);
                float y = radius * (float)Math.Sin(i * angleStep - Math.PI / 2);
                points.Add(new PointF(x, y));
            }
            return points;
        }

        public static EulerianFigure CreateHeptagram()
        {
            var points = GenerateRegularPolygon(7, 100);
            var path = new List<int>();

            int current = 0;
            int step = 3;
            do
            {
                path.Add(current);
                current = (current + step) % 7;
            } while (!path.Contains(current));
            path.Add(current); // cerrar el ciclo

            return new EulerianFigure(points, path);
        }

        public static EulerianFigure CreateEnneagram()
        {
            var points = GenerateRegularPolygon(9, 100);
            var path = new List<int>();

            int current = 0;
            int step = 4;
            do
            {
                path.Add(current);
                current = (current + step) % 9;
            } while (!path.Contains(current));
            path.Add(current); // cerrar el ciclo

            return new EulerianFigure(points, path);
        }

        public static EulerianFigure CreateStarOfDavid()
        {
            var triangle1 = GenerateRegularPolygon(3, 100);
            var triangle2 = GenerateRegularPolygon(3, 100);
            for (int i = 0; i < triangle2.Count; i++)
                triangle2[i] = new PointF(triangle2[i].X, -triangle2[i].Y); // triángulo invertido

            var allPoints = triangle1.Concat(triangle2).ToList();

            var path = new List<int>
        {
            0, 1, 2, 0, 3, 4, 5, 3
        };

            return new EulerianFigure(allPoints, path);
        }

        public static EulerianFigure CreatePentagonWithStar()
        {
            var outer = GenerateRegularPolygon(5, 100);
            var path = new List<int>();

            for (int i = 0; i < 5; i++)
                path.Add(i);
            path.Add(0);

            int current = 0;
            int step = 2;
            var starPath = new List<int>();
            do
            {
                starPath.Add(current);
                current = (current + step) % 5;
            } while (!starPath.Contains(current));
            starPath.Add(current);

            // Unimos los caminos pentágono + estrella
            path.AddRange(starPath);

            return new EulerianFigure(outer, path);
        }

        public static EulerianFigure CreateGridWithDiagonals()
        {
            int rows = 4, cols = 4;
            float spacing = 40;
            var points = new List<PointF>();
            var pointIndex = new Dictionary<(int, int), int>();
            int idx = 0;

            // Crear la grilla de puntos
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    float px = spacing * x - spacing * (cols - 1) / 2;
                    float py = spacing * y - spacing * (rows - 1) / 2;
                    points.Add(new PointF(px, py));
                    pointIndex[(x, y)] = idx++;
                }
            }

            var path = new List<int>();

            for (int y = 0; y < rows; y++)
            {
                if (y % 2 == 0)
                {
                    for (int x = 0; x < cols; x++)
                        path.Add(pointIndex[(x, y)]);
                }
                else
                {
                    for (int x = cols - 1; x >= 0; x--)
                        path.Add(pointIndex[(x, y)]);
                }
            }

            for (int y = 0; y < rows - 1; y++)
            {
                for (int x = 0; x < cols - 1; x++)
                {
                    int i = pointIndex[(x, y)];
                    int j = (x + y) % 2 == 0
                        ? pointIndex[(x + 1, y + 1)]
                        : pointIndex[(x + 1, y)] + 1;

                    path.Add(i);
                    path.Add(j);
                }
            }

            return new EulerianFigure(points, path);
        }

    }

}