using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sagnay_Luis_Leccion2
{
    public class ClockDrawer
    {
        private Timer timer;
        private PictureBox canvas;
        private DDAAlgorithm dda = new DDAAlgorithm();
        private BresenhamCircle circle = new BresenhamCircle();

        public ClockDrawer(PictureBox canvas)
        {
            this.canvas = canvas;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => DrawClock();
            timer.Start();
        }

        public void DrawClock()
        {
            Graphics g = canvas.CreateGraphics();
            g.Clear(Color.White);

            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;
            int radius = 100;

            circle.Draw(canvas);

            DrawTicks(centerX, centerY, radius);
            DrawHands(centerX, centerY, radius);
        }

        private void DrawTicks(int xc, int yc, int r)
        {
            for (int i = 0; i < 60; i++)
            {
                double angle = i * Math.PI / 30;
                int inner = r - (i % 5 == 0 ? 10 : 5);

                int x1 = xc + (int)(inner * Math.Sin(angle));
                int y1 = yc - (int)(inner * Math.Cos(angle));
                int x2 = xc + (int)(r * Math.Sin(angle));
                int y2 = yc - (int)(r * Math.Cos(angle));

                dda.DrawLine(canvas, x1 - xc, yc - y1, x2 - xc, yc - y2, Color.Violet, 2); 
            }
        }

        private void DrawHands(int xc, int yc, int r)
        {
            DateTime now = DateTime.Now;

            double secAngle = now.Second * 6 * Math.PI / 180;
            double minAngle = (now.Minute + now.Second / 60.0) * 6 * Math.PI / 180;
            double hourAngle = (now.Hour % 12 + now.Minute / 60.0) * 30 * Math.PI / 180;

            int xs = xc + (int)(r * 0.9 * Math.Sin(secAngle));
            int ys = yc - (int)(r * 0.9 * Math.Cos(secAngle));
            dda.DrawLine(canvas, 0, 0, xs - xc, yc - ys, Color.Red, 1);

            int xm = xc + (int)(r * 0.7 * Math.Sin(minAngle));
            int ym = yc - (int)(r * 0.7 * Math.Cos(minAngle));
            dda.DrawLine(canvas, 0, 0, xm - xc, yc - ym, Color.Blue, 2);

            int xh = xc + (int)(r * 0.5 * Math.Sin(hourAngle));
            int yh = yc - (int)(r * 0.5 * Math.Cos(hourAngle));
            dda.DrawLine(canvas, 0, 0, xh - xc, yc - yh, Color.Black, 3);
        }
    }
}
