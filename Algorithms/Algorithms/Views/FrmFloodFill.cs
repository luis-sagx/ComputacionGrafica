using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Algorithm;
using Algorithms.Algorithm.Fill;
using Algorithms.Domain.Abstract;

namespace Algorithms.Views
{
    public partial class FrmFloodFill : Form
    {
        private FillAlgorithm _floodFill;
        private readonly ColorDialog _colorDialog = new ColorDialog();

        public FrmFloodFill()
        {
            InitializeComponent();
            _colorDialog.Color = Color.RoyalBlue;
            btnSelectColor.BackColor = _colorDialog.Color;
        }

        private void FrmFloodFill_Load(object sender, EventArgs e)
        {
            cmbShape.Items.Add("Polygon");
            cmbShape.Items.Add("Star");
            cmbShape.SelectedIndex = 0;

            picCanvas.MouseClick += async (s, e2) =>
            {
                if (_floodFill != null)
                    await _floodFill.FillAsync(e2.X, e2.Y, picCanvas);
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isStar = cmbShape.SelectedItem?.ToString() == "Star";

            if (rbRecursive.Checked)
                _floodFill = new FloodFillAlgorithm();
            else
                _floodFill = new FillIterativeAlgorithm();

            _floodFill.FillColor = _colorDialog.Color;

            _floodFill.ReadData(txtSides, isStar);
            _floodFill.PlotFigure(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _floodFill?.InitializeData(txtSides, cmbShape, picCanvas);
            picCanvas.Image = null;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnSelectColor.BackColor = _colorDialog.Color;
                if (_floodFill != null)
                    _floodFill.FillColor = _colorDialog.Color;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }
    }
}
