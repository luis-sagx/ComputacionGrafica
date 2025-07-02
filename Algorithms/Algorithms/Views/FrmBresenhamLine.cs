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

namespace Algorithms.Views
{
    public partial class FrmBresenhamLine : Form
    {
        private BresenhamAlgorithm objAlgoritmoBresenham = new BresenhamAlgorithm();
        public FrmBresenhamLine()
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
            objAlgoritmoBresenham.Draw(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoBresenham.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas);
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message =
            "📌 How to use the Bresenham Line Drawing Form:\n\n" +
            "1. Enter the coordinates of the two points:\n" +
            "   - X and Y (both between -150 and 150)\n\n" +
            "   - First point: Xi and Yi\n" +
            "   - Second point: Xf and Yf\n\n" +
            "2. Click the 'Draw' button to draw the Cartesian plane and the line using the Bresenham algorithm.\n\n" +
            "3. Click the 'Reset' button to clear the canvas and input fields.\n\n" +
            "4. Click the 'Back' button to return to the main menu.\n\n" +
            "💡 The pixels are drawn step-by-step.";

            MessageBox.Show(message, "Bresenham Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
