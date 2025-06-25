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
    public partial class FrmBresenhamCircle : Form
    {
        private BresenhamCircle objAlgoritmoCirculo = new BresenhamCircle();
        public FrmBresenhamCircle()
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

        private void FrmCirculo_Load(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.InitializeData(txtPuntox, txtPuntoy, txtRadius, picCanvas, dataGridViewPuntos);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.ReadData(txtPuntox, txtPuntoy, txtRadius);
            InicializarDataGridView(dataGridViewPuntos);
            objAlgoritmoCirculo.Draw(picCanvas, dataGridViewPuntos);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoCirculo.InitializeData(txtPuntox, txtPuntoy, txtRadius, picCanvas, dataGridViewPuntos);
        }
    }
}
