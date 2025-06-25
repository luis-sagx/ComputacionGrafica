using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica2.Algorithms;

namespace practica2.View
{
    public partial class FrmBresenhamLine : Form
    {
        private BresenhamLine objAlgoritmoBresenham = new BresenhamLine();
        public FrmBresenhamLine()
        {
            InitializeComponent();
        }

        public void InicializarDataGridView(DataGridView dataGridViewPuntos)
        {
            dataGridViewPuntos.Columns.Clear();
            dataGridViewPuntos.Columns.Add("Pasos", "Paso");
            dataGridViewPuntos.Columns.Add("X", "X");
            dataGridViewPuntos.Columns.Add("Y", "Y");
        }

        private void FrmBresenham_Load(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas, dataGridViewPuntos);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.ReadData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy);
            InicializarDataGridView(dataGridViewPuntos);
            objAlgoritmoBresenham.Draw(picCanvas, dataGridViewPuntos);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas, dataGridViewPuntos);
        }

    }
}
