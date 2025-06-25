using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2.View
{
    public partial class FrmDDA : Form
    {
        private DDAAlgorithm objAlgoritmoDDA = new DDAAlgorithm();

        public void InicializarDataGridView(DataGridView dataGridViewPuntos)
        {
            dataGridViewPuntos.Columns.Clear();
            dataGridViewPuntos.Columns.Add("Pasos", "Paso");
            dataGridViewPuntos.Columns.Add("X", "X");
            dataGridViewPuntos.Columns.Add("Y", "Y");
        }
        public FrmDDA()
        {
            InitializeComponent();
        }

        private void FrmDDA_Load(object sender, EventArgs e)
        {
            objAlgoritmoDDA.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas, dataGridViewPuntos);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoDDA.ReadData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy);
            InicializarDataGridView(dataGridViewPuntos);
            objAlgoritmoDDA.Draw(picCanvas, dataGridViewPuntos);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoDDA.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas, dataGridViewPuntos);
        }

    }
}
