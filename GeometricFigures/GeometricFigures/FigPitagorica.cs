using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public class FigPitagorica
    {
        private float mRadio;
        private Graphics mGraph;
        private const float SF = 20.0f; // Scale Factor
        private Pen penCirculo;
        private Pen penEstrella;
        private Pen penInterno;
        private Pen penTriangulos;

        public FigPitagorica()
        {
            mRadio = 0.0f;
        }

        public void ReadData(TextBox txtRadio)
        {
            try
            {
                mRadio = float.Parse(txtRadio.Text);
            }
            catch
            {
                MessageBox.Show("Input inválido", "Mensaje de error");
            }
        }

        public void InitializeData(TextBox txtRadio, PictureBox picCanvas)
        {
            mRadio = 0.0f;
            txtRadio.Text = "";
            txtRadio.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            penCirculo = new Pen(Color.Black, 2);
            penEstrella = new Pen(Color.Blue, 1.5f);
            penInterno = new Pen(Color.Green, 1.5f);
            penTriangulos = new Pen(Color.Red, 1.5f);

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;
            PointF centro = new PointF(centerX, centerY);
            float radioEscalado = mRadio * SF;

            // Círculo principal
            mGraph.DrawEllipse(penCirculo, centro.X - radioEscalado, centro.Y - radioEscalado, 2 * radioEscalado, 2 * radioEscalado);

            // Pentágono exterior
            PointF[] pentagono = ObtenerVertices(centro, radioEscalado, 5, -90);

            // Estrella azul (pentagrama exterior)
            for (int i = 0; i < 5; i++)
            {
                mGraph.DrawLine(penEstrella, pentagono[i], pentagono[(i + 2) % 5]);
            }

            // Triángulos exteriores (rojos)
            for (int i = 0; i < 5; i++)
            {
                mGraph.DrawLine(penTriangulos, pentagono[i], pentagono[(i + 1) % 5]);
            }

            // Pentágono interior (verde, proporción áurea)
            PointF[] interior = ObtenerVertices(centro, radioEscalado * 0.382f, 5, -90);
            for (int i = 0; i < 5; i++)
            {
                mGraph.DrawLine(penInterno, interior[i], interior[(i + 2) % 5]);
            }

            // Líneas grises del centro a cada vértice exterior
            foreach (PointF p in pentagono)
            {
                mGraph.DrawLine(Pens.Gray, centro, p);
            }
        }

        private PointF[] ObtenerVertices(PointF centro, float radio, int lados, float anguloInicial)
        {
            PointF[] puntos = new PointF[lados];
            double angulo = anguloInicial * Math.PI / 180;

            for (int i = 0; i < lados; i++)
            {
                float x = centro.X + radio * (float)Math.Cos(angulo);
                float y = centro.Y + radio * (float)Math.Sin(angulo);
                puntos[i] = new PointF(x, y);
                angulo += 2 * Math.PI / lados;
            }

            return puntos;
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

































/**
public partial class FrmHoney : Form
    {
        public FrmHoney()
        {
            InitializeComponent();
        }
        private void bntCalculate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtLado.Text, out float lado) && lado > 0)
            {
                Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Transparent);

                    Honey honey = new Honey(g, lado);
                    honey.DrawHexagonGrid(4, picCanvas.Width, picCanvas.Height); // 4 = tamaño del panal (puedes probar con 3, 5, etc.)

                    picCanvas.Image = bmp;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor válido para el lado del hexágono.");
            }
        }

    }

internal class Honey
    {
        private Graphics g;
        private float side; // Lado del hexágono
        private float h;    // Altura del triángulo (h = lado * √3 / 2)
        private float r;    // Apotema (distancia desde el centro al lado)
        private Pen pen;
        private Brush brush;

        public Honey(Graphics g, float side)
        {
            this.g = g;
            this.side = side;
            this.h = (float)(Math.Sqrt(3) / 2 * side);
            this.r = side / 2;
            pen = new Pen(Color.Orange, 1);
            brush = new SolidBrush(Color.Gold);
        }
        public void DrawHexagon(float centerX, float centerY)
        {
            PointF[] points = new PointF[6];

            for (int i = 0; i < 6; i++)
            {
                float angle_deg = 60 * i - 30;
                float angle_rad = (float)(Math.PI / 180 * angle_deg);
                points[i] = new PointF(
                    centerX + side * (float)Math.Cos(angle_rad),
                    centerY + side * (float)Math.Sin(angle_rad));
            }

            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }
        public void DrawHexagonGrid(int n, float canvasWidth, float canvasHeight)
        {
            float dx = side * 1.7f;
            float dy = side * (float)Math.Sqrt(8);

            int totalRows = 2 * n - 1;

            // Calcula dimensiones del panal completo
            float totalHeight = dy * totalRows / 2;
            float totalWidth = dx * (n + n - 1);

            float startX = (canvasWidth - totalWidth) / 2;
            float startY = (canvasHeight - totalHeight) / 2;

            for (int row = 0; row < totalRows; row++)
            {
                int colsInRow = n + Math.Min(row, totalRows - row - 1);
                float y = startY + row * (dy / 2);

                for (int col = 0; col < colsInRow; col++)
                {
                    float x = startX + col * dx + ((n - 1 - Math.Min(row, totalRows - row - 1)) * dx / 2);
                    DrawHexagon(x, y);
                }
            }
        }

    }

*/
