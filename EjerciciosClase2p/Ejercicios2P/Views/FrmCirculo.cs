using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios2P.Utils;
using Ejercicios2P.Views;

namespace Ejercicios2P.DrawCircle
{
    public partial class FrmCirculo : Form
    {
        private CirculoBresenham objAlgoritmoCirculo = new CirculoBresenham();
        public FrmCirculo()
        {
            InitializeComponent();
        }

        private void FrmCirculo_Load(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.InitializeData(txtPuntox, txtPuntoy, txtRadius, picCanvas, dataGridViewPuntos);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.ReadData(txtPuntox, txtPuntoy, txtRadius);
            Table.InicializarDataGridViewCirculo(dataGridViewPuntos);
            objAlgoritmoCirculo.Draw(picCanvas, dataGridViewPuntos);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.InitializeData(txtPuntox, txtPuntoy, txtRadius, picCanvas, dataGridViewPuntos);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.CloseForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }
    }
}
