using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private CancellationTokenSource _cts;

        public FrmFloodFill()
        {
            InitializeComponent();
            rbIterative.Checked = true;
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
                    await _floodFill.FillAsync(e2.X, e2.Y, picCanvas, _cts.Token);
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isStar = cmbShape.SelectedItem?.ToString() == "Star";

            _cts = new CancellationTokenSource();

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
            _cts?.Cancel();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "🧠 Flood Fill Form Help Guide\n\n" +
                             "1. Select the algorithm you want to use:\n" +
                             "   - Recursive\n" +
                             "   - Iterative\n\n" +
                             "2. Choose the shape to draw:\n" +
                             "   - Regular Polygon\n" +
                             "   - Regular Star\n\n" +
                             "3. Enter the number of points (from 3 to 20) to define the shape.\n\n" +
                             "4. Choose a fill color (optional):\n" +
                             "   - Default fill color is blue.\n\n" +
                             "5. Use the buttons:\n" +
                             "   - Draw: generates the selected shape with the chosen parameters.\n" +
                             "   - Click inside the shape: to start the flood fill algorithm step by step.\n" +
                             "   - Reset: clears the current drawing.\n\n" +
                             "👉 Important: you must draw the shape first, then click inside it to begin filling.";

            MessageBox.Show(message, "Help - Flood Fill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
