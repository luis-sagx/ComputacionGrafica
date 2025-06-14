using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios2P.Algorithms;
using Ejercicios2P.Utils;

namespace Ejercicios2P.Views
{
    public partial class FrmFloodFill : Form
    {
        private readonly FloodFillAlgorithm _floodFill = new FloodFillAlgorithm();
        private readonly ColorDialog _colorDialog = new ColorDialog();
        public FrmFloodFill()
        {
            InitializeComponent();
            _colorDialog.Color = Color.RoyalBlue;
            btnSelectColor.BackColor = _colorDialog.Color;
        }

        private void FrmFloodFill_Load(object sender, EventArgs e)
        {
            _floodFill.InitializeData(txtSides, picCanvas, dataGridViewPuntos);
            Table.InicializarDataGridView(dataGridViewPuntos);

            picCanvas.MouseClick += async (s, e2) =>
            {
                await _floodFill.FloodFillAsync(e2.X, e2.Y, picCanvas, dataGridViewPuntos);
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                _floodFill.ReadData(txtSides);
                int sides = int.Parse(txtSides.Text);
                _floodFill.PlotPolygon(sides, picCanvas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _floodFill.InitializeData(txtSides, picCanvas, dataGridViewPuntos);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        { 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnSelectColor.BackColor = _colorDialog.Color;
                _floodFill.FillColor = _colorDialog.Color;
            }
        }
    }
}
