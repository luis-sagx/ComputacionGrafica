using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios2P.Bresenham
{
    public partial class FrmBresenham : Form
    {
        private AlgoritmoBresenham objAlgoritmoBresenham = new AlgoritmoBresenham();
        public FrmBresenham()
        {
            InitializeComponent();
        }

        private void FrmBresenham_Load(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.ReadData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy);
            objAlgoritmoBresenham.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.CloseForm(this);
        }
    }
}
