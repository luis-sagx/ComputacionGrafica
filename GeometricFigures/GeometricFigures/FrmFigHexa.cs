using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public partial class FrmFigHexa : Form
    {
        private GeometricFigure ObjFigure = new GeometricFigure();

        public FrmFigHexa()
        {
            InitializeComponent();
        }

        private void FrmGeometricFigure_Load(object sender, EventArgs e)
        {
            ObjFigure.InitializeData(txtSide, picCanvas);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            ObjFigure.ReadData(txtSide);
            ObjFigure.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjFigure.InitializeData(txtSide, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjFigure.CloseForm(this);
        }
    }
}
