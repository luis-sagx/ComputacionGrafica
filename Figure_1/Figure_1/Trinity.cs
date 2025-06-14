using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure_1
{
    public class Trinity
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 15; // Scale factor para visualización
        private Pen mPenTriangle;
        private Pen mPenHexagram;
        private Pen mPenInnerTriangle;

        public Trinity()
        {
            mSide = mPerimeter = mArea = 0.0f;
            mPenTriangle = new Pen(Color.Black, 3);
            mPenHexagram = new Pen(Color.Red, 2);
            mPenInnerTriangle = new Pen(Color.Blue, 2);
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                if (mSide <= 0)
                {
                    throw new ArgumentException("El lado debe ser mayor que cero");
                }
            }
            catch
            {
                MessageBox.Show("Entrada inválida. Por favor ingrese un número positivo.", "Error de Entrada");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 3 * mSide;
        }

        public void CalculateArea()
        {
            // Área de un triángulo equilátero: (lado²√3)/4
            mArea = (float)(mSide *mSide * Math.Sqrt(3) / 4);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSide = mPerimeter = mArea = 0.0f;
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            if (mSide <= 0) return;

            mGraph = picCanvas.CreateGraphics();

            // Centrar la figura en el PictureBox
            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            // Calcular la altura del triángulo equilátero
            float height = (float)(mSide * Math.Sqrt(3) / 2) * SF;
            float scaledSide = mSide * SF;

            // Puntos del triángulo principal (equilátero)
            PointF[] mainTriangle = new PointF[3];
            mainTriangle[0] = new PointF(centerX, centerY - height * 2 / 3); // Vértice superior
            mainTriangle[1] = new PointF(centerX - scaledSide / 2, centerY + height / 3); // Vértice inferior izquierdo
            mainTriangle[2] = new PointF(centerX + scaledSide / 2, centerY + height / 3); // Vértice inferior derecho

            // Dibujar el triángulo principal
            mGraph.DrawPolygon(mPenTriangle, mainTriangle);

            // Calcular puntos para la estrella de seis puntas (hexagrama)
            // Triángulo hacia arriba (rojo)
            float innerRadius = scaledSide / 3;
            PointF[] upTriangle = new PointF[3];
            upTriangle[0] = new PointF(centerX, centerY - innerRadius);
            upTriangle[1] = new PointF(centerX - innerRadius * (float)Math.Cos(Math.PI / 6),
                                      centerY + innerRadius * (float)Math.Sin(Math.PI / 6));
            upTriangle[2] = new PointF(centerX + innerRadius * (float)Math.Cos(Math.PI / 6),
                                      centerY + innerRadius * (float)Math.Sin(Math.PI / 6));

            // Triángulo hacia abajo (rojo)
            PointF[] downTriangle = new PointF[3];
            downTriangle[0] = new PointF(centerX, centerY + innerRadius);
            downTriangle[1] = new PointF(centerX - innerRadius * (float)Math.Cos(Math.PI / 6),
                                        centerY - innerRadius * (float)Math.Sin(Math.PI / 6));
            downTriangle[2] = new PointF(centerX + innerRadius * (float)Math.Cos(Math.PI / 6),
                                        centerY - innerRadius * (float)Math.Sin(Math.PI / 6));

            // Dibujar los triángulos del hexagrama
            mGraph.DrawPolygon(mPenHexagram, upTriangle);
            mGraph.DrawPolygon(mPenHexagram, downTriangle);

            // Dibujar hexágono interior (azul)
            PointF[] hexagon = new PointF[6];
            float hexRadius = innerRadius * 0.6f;
            for (int i = 0; i < 6; i++)
            {
                float angle = (float)(i * Math.PI / 3);
                hexagon[i] = new PointF(
                    centerX + hexRadius * (float)Math.Cos(angle),
                    centerY + hexRadius * (float)Math.Sin(angle)
                );
            }
            mGraph.DrawPolygon(mPenInnerTriangle, hexagon);

            // Dibujar líneas de conexión internas (azul)
            for (int i = 0; i < 6; i += 2)
            {
                mGraph.DrawLine(mPenInnerTriangle, hexagon[i], hexagon[(i + 3) % 6]);
            }
        }

        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }

        // Método para limpiar recursos
        public void Dispose()
        {
            mPenTriangle?.Dispose();
            mPenHexagram?.Dispose();
            mPenInnerTriangle?.Dispose();
            mGraph?.Dispose();
        }
    }
}
