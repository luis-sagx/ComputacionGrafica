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

namespace Ejercicios2P.Bresenham
{
    public partial class FrmBresenham : Form
    {
        private BresenhamAlgorithm objAlgoritmoBresenham = new BresenhamAlgorithm();
        public FrmBresenham()
        {
            InitializeComponent();
        }

        private void FrmBresenham_Load(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas, dataGridViewPuntos);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.ReadData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy);
            Table.InicializarDataGridView(dataGridViewPuntos);
            objAlgoritmoBresenham.Draw(picCanvas, dataGridViewPuntos);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas, dataGridViewPuntos);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.CloseForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }
    }
}
