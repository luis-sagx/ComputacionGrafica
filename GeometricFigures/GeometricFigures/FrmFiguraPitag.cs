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
    public partial class FrmFiguraPitag : Form
    {
        private FigPitagorica objFigura = new FigPitagorica();
        public FrmFiguraPitag()
        {
            InitializeComponent();
        }
        private void btnDibujar_Click(object sender, EventArgs e)
        {
            objFigura = new FigPitagorica();
            objFigura.ReadData(txtRadio);
            objFigura.PlotShape(picCanvas); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objFigura.InitializeData(txtRadio, picCanvas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            objFigura.CloseForm(this);
        }

    }
}
