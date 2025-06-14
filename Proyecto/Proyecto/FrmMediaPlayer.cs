using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmMediaPlayer : Form
    {
        private enum PlayerState { Stopped, Playing, Paused }
        private PlayerState currentState = PlayerState.Stopped;

        private Rectangle btnPlay, btnPause, btnStop, btnForward, btnBack, progressBar;
        private int progress = 0;
        private Timer playbackTimer;

        public FrmMediaPlayer()
        {
            InitializeComponent();
            this.Text = "Simulación de Windows Media Player";
            this.Width = 600;
            this.Height = 300;

            PictureBox canvas = new PictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Black
            };
            canvas.MouseClick += Canvas_MouseClick;
            canvas.Paint += Canvas_Paint;
            this.Controls.Add(canvas);

            // Botones renombrados
            btnPlay = new Rectangle(100, 200, 40, 40);
            btnPause = new Rectangle(150, 200, 40, 40);
            btnStop = new Rectangle(200, 200, 40, 40);
            btnBack = new Rectangle(50, 200, 40, 40);
            btnForward = new Rectangle(250, 200, 40, 40);
            progressBar = new Rectangle(50, 150, 500, 10);

            // Timer
            playbackTimer = new Timer();
            playbackTimer.Interval = 100;
            playbackTimer.Tick += (s, e) =>
            {
                if (currentState == PlayerState.Playing)
                {
                    progress += 2;
                    if (progress > progressBar.Width)
                    {
                        progress = progressBar.Width;
                        currentState = PlayerState.Stopped;
                        playbackTimer.Stop();
                    }
                    canvas.Invalidate();
                }
            };
        }

        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnPlay.Contains(e.Location))
            {
                currentState = PlayerState.Playing;
                playbackTimer.Start();
            }
            else if (btnPause.Contains(e.Location))
            {
                currentState = PlayerState.Paused;
                playbackTimer.Stop();
            }
            else if (btnStop.Contains(e.Location))
            {
                currentState = PlayerState.Stopped;
                playbackTimer.Stop();
                progress = 0;
            }
            else if (btnForward.Contains(e.Location))
            {
                progress = Math.Min(progress + 20, progressBar.Width);
            }
            else if (btnBack.Contains(e.Location))
            {
                progress = Math.Max(progress - 20, 0);
            }

            ((PictureBox)sender).Invalidate();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Dibujar botones con los nuevos nombres
            DrawPlay(g, btnPlay);
            DrawPause(g, btnPause);
            DrawStop(g, btnStop);
            DrawForward(g, btnForward);
            DrawBack(g, btnBack);

            // Dibujar barra de progreso
            g.FillRectangle(Brushes.Gray, progressBar);
            g.FillRectangle(Brushes.LimeGreen, new Rectangle(progressBar.X, progressBar.Y, progress, progressBar.Height));
        }

        private void DrawPlay(Graphics g, Rectangle rect)
        {
            Point p1 = new Point(rect.X + 5, rect.Y + 5);
            Point p2 = new Point(rect.Right - 5, rect.Y + rect.Height / 2);
            Point p3 = new Point(rect.X + 5, rect.Bottom - 5);
            g.FillPolygon(Brushes.White, new[] { p1, p2, p3 });
        }

        private void DrawPause(Graphics g, Rectangle rect)
        {
            g.FillRectangle(Brushes.White, rect.X + 5, rect.Y + 5, 8, rect.Height - 10);
            g.FillRectangle(Brushes.White, rect.X + 20, rect.Y + 5, 8, rect.Height - 10);
        }

        private void DrawStop(Graphics g, Rectangle rect)
        {
            g.FillRectangle(Brushes.White, rect.X + 8, rect.Y + 8, rect.Width - 16, rect.Height - 16);
        }

        private void DrawForward(Graphics g, Rectangle rect)
        {
            Point p1 = new Point(rect.X + 5, rect.Y + 5);
            Point p2 = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            Point p3 = new Point(rect.X + 5, rect.Bottom - 5);
            Point p4 = new Point(rect.X + rect.Width / 2, rect.Y + 5);
            Point p5 = new Point(rect.Right - 5, rect.Y + rect.Height / 2);
            Point p6 = new Point(rect.X + rect.Width / 2, rect.Bottom - 5);
            g.FillPolygon(Brushes.White, new[] { p1, p2, p3 });
            g.FillPolygon(Brushes.White, new[] { p4, p5, p6 });
        }

        private void DrawBack(Graphics g, Rectangle rect)
        {
            Point p1 = new Point(rect.Right - 5, rect.Y + 5);
            Point p2 = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            Point p3 = new Point(rect.Right - 5, rect.Bottom - 5);
            Point p4 = new Point(rect.X + rect.Width / 2, rect.Y + 5);
            Point p5 = new Point(rect.X + 5, rect.Y + rect.Height / 2);
            Point p6 = new Point(rect.X + rect.Width / 2, rect.Bottom - 5);
            g.FillPolygon(Brushes.White, new[] { p1, p2, p3 });
            g.FillPolygon(Brushes.White, new[] { p4, p5, p6 });
        }
    }
}
