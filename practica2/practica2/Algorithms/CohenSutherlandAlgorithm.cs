using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2.Algorithms
{
    public class CohenSutherlandAlgorithm
    {
        private const byte INSIDE = 0;
        private const byte LEFT = 1;
        private const byte RIGHT = 2;
        private const byte BOTTOM = 4;
        private const byte UP = 8;
        private int xMin, xMax, yMin, yMax;
        private int x_1, y_1, x_2, y_2;
        private bool hasClippedLine;

        public CohenSutherlandAlgorithm(int xMin, int xMax, int yMin, int yMax)
        {
            this.xMin = xMin;
            this.xMax = xMax;
            this.yMin = yMin;
            this.yMax = yMax;
            InitializeClippedLine();
        }

        private void InitializeClippedLine()
        {
            x_1 = y_1 = x_2 = y_2 = 0;
            hasClippedLine = false;
        }

        private byte ComputeOutCode(int x, int y, int xmax, int xmin, int ymax, int ymin)
        {
            byte code = INSIDE;
            if (x < xmin) code |= LEFT;
            else if (x > xmax) code |= RIGHT;
            if (y < ymin) code |= BOTTOM;
            else if (y > ymax) code |= UP;
            return code;
        }

        public bool clipLine(int x1, int y1, int x2, int y2)
        {
            InitializeClippedLine();

            byte code1 = ComputeOutCode(x1, y1, xMax, xMin, yMax, yMin);
            byte code2 = ComputeOutCode(x2, y2, xMax, xMin, yMax, yMin);
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
                else
                {
                    int x = 0, y = 0;
                    byte codeOut = (code1 != 0) ? code1 : code2;

                    if ((codeOut & UP) != 0)
                    {
                        x = x1 + (x2 - x1) * (yMax - y1) / (y2 - y1);
                        y = yMax;
                    }
                    else if ((codeOut & BOTTOM) != 0)
                    {
                        x = x1 + (x2 - x1) * (yMin - y1) / (y2 - y1);
                        y = yMin;
                    }
                    else if ((codeOut & RIGHT) != 0)
                    {
                        y = y1 + (y2 - y1) * (xMax - x1) / (x2 - x1);
                        x = xMax;
                    }
                    else if ((codeOut & LEFT) != 0)
                    {
                        y = y1 + (y2 - y1) * (xMin - x1) / (x2 - x1);
                        x = xMin;
                    }

                    if (codeOut == code1)
                    {
                        x1 = x;
                        y1 = y;
                        code1 = ComputeOutCode(x1, y1, xMax, xMin, yMax, yMin);
                    }
                    else
                    {
                        x2 = x;
                        y2 = y;
                        code2 = ComputeOutCode(x2, y2, xMax, xMin, yMax, yMin);
                    }
                }
            }

            if (accept)
            {
                x_1 = x1;
                y_1 = y1;
                x_2 = x2;
                y_2 = y2;
                hasClippedLine = true;
            }

            return accept;
        }

        public (int x1, int y1, int x2, int y2)? GetClippedLine()
        {
            if (!hasClippedLine)
                return null;
            return (x_1, y_1, x_2, y_2);
        }
    }
}