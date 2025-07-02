using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Algorithm.Rasterization;

namespace Algorithms.Views
{
    public partial class FrmBresenhamEllipse : Form
    {
        EllipseBresenham objEllipseBresenham = new EllipseBresenham();
        public FrmBresenhamEllipse()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objEllipseBresenham.ReadData(txtPuntox, txtPuntoy, txtRadioX, txtRadioY);
            objEllipseBresenham.Draw(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objEllipseBresenham.InitializeData(txtPuntox, txtPuntoy, txtRadioX, txtRadioY, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }

        private void FrmBresenhamEllipse_Load(object sender, EventArgs e)
        {
            objEllipseBresenham.InitializeData(txtPuntox, txtPuntoy, txtRadioX, txtRadioY, picCanvas);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message =
                "📌 How to use the Bresenham Ellipse Drawing Form:\n\n" +
                "1. Enter the coordinates of the ellipse's center:\n" +
                "   - X and Y (both between -100 and 100)\n\n" +
                "2. Enter the semi-axes a of the ellipse (between 0 and 150).\n\n" +
                "3. Enter the semi-axes b of the ellipse (between 0 and 150).\n\n" +
                "4. Click the 'Draw' button to draw the ellipse using Bresenham's ellipse algorithm.\n\n" +
                "5. Click the 'Reset' button to clear the canvas and input fields.\n\n" +
                "6. Click the 'Back' button to return to the main menu.\n\n" +
                "💡 The ellipse is drawn symmetrically using the 8-way symmetry principle, and each pixel is displayed one by one.";

            MessageBox.Show(message, "Bresenham Ellipse Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
