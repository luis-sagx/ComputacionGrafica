using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void itmSquare_Click(object sender, EventArgs e)
        {
            FrmSquare square = new FrmSquare();
            square.Show();
            this.Hide();
        }

        private void itmRectangle_Click(object sender, EventArgs e)
        {
            FrmRectangle rectangle = new FrmRectangle();
            rectangle.Show();
            this.Hide();
        }

        private void itmTriangle_Click(object sender, EventArgs e)
        {
            FrmTriangle triangle = new FrmTriangle();
            triangle.Show();
            this.Hide();
        }

        private void itmCircle_Click(object sender, EventArgs e)
        {
            FrmCircle circle = new FrmCircle();
            circle.Show();
            this.Hide();
        }

        private void itmElipse_Click(object sender, EventArgs e)
        {
            FrmElipse elipse = new FrmElipse();
            elipse.Show();
            this.Hide();
        }

        private void itmSemicircle_Click(object sender, EventArgs e)
        {
            FrmSemicircle semicircle = new FrmSemicircle();
            semicircle.Show();
            this.Hide();
        }

        private void itmTrapezoid_Click(object sender, EventArgs e)
        {
            FrmTrapezoid trapezoid = new FrmTrapezoid();
            trapezoid.Show();
            this.Hide();
        }

        private void itmTrapezoide_Click(object sender, EventArgs e)
        {
            FrmTrapezoide trapezoide = new FrmTrapezoide();
            trapezoide.Show();
            this.Hide();
        }

        private void itmRhombus_Click(object sender, EventArgs e)
        {
            FrmRhombus rhombus = new FrmRhombus();
            rhombus.Show();
            this.Hide();
        }

        private void itmRhomboid_Click(object sender, EventArgs e)
        {
            FrmRhomboid rhomboid = new FrmRhomboid();
            rhomboid.Show();
            this.Hide();
        }

        private void itmDeltoid_Click(object sender, EventArgs e)
        {
            FrmDeltoid deltoid = new FrmDeltoid();
            deltoid.Show();
            this.Hide();
        }

        private void itmStar_Click(object sender, EventArgs e)
        {
            FrmStar frmStar = new FrmStar();
            frmStar.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
