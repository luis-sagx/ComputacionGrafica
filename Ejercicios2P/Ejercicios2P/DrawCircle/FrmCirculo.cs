using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios2P.DrawCircle
{
    public partial class FrmCirculo : Form
    {
        private AlgoritmoCirculo objAlgoritmoCirculo = new AlgoritmoCirculo();
        public FrmCirculo()
        {
            InitializeComponent();
        }

        private void FrmCirculo_Load(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.InitializeData(txtPuntox, txtPuntoy, txtRadius, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.ReadData(txtPuntox, txtPuntoy, txtRadius);
            objAlgoritmoCirculo.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.InitializeData(txtPuntox, txtPuntoy, txtRadius, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.CloseForm(this);
        }
    }
}
