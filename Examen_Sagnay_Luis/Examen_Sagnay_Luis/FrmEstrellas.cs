using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Sagnay_Luis
{
    public partial class FrmEstrellas : Form
    {
        private Estrellas objEstrellas = new Estrellas();
        public FrmEstrellas()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objEstrellas.ReadData(txtSide);
            objEstrellas.PlotShape(picCanvas);
        }

        private void FrmEstrellas_Load(object sender, EventArgs e)
        {
            objEstrellas.InitializeData(txtSide, picCanvas);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objEstrellas.InitializeData(txtSide, picCanvas);
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            objEstrellas.RotateLeft(picCanvas);
        }

        private void btnRotateRigth_Click(object sender, EventArgs e)
        {
            objEstrellas.RotateRight(picCanvas);

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            objEstrellas.ZoomIn(picCanvas);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            objEstrellas.ZoomOut(picCanvas);
        }
    }


}
