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
    public partial class FrmBresenhamCircle : Form
    {
        private CircleBresenham objCircleBresenham = new CircleBresenham();
        public FrmBresenhamCircle()
        {
            InitializeComponent();
        }

        private void FrmBresenhamCircle_Load(object sender, EventArgs e)
        {
            objCircleBresenham.InitializeData(txtPuntox,txtPuntoy, txtRadius, txtRadius, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objCircleBresenham.ReadData(txtPuntox, txtPuntoy, txtRadius, txtRadius);
            objCircleBresenham.Draw(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objCircleBresenham.InitializeData(txtPuntox, txtPuntoy, txtRadius, txtRadius, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message =
                "📌 How to use the Bresenham Circle Drawing Form:\n\n" +
                "1. Enter the coordinates of the circle's center:\n" +
                "   - X and Y (both between -100 and 100)\n\n" +
                "2. Enter the radius of the circle (between 0 and 150).\n\n" +
                "3. Click the 'Draw' button to draw the circle using Bresenham's circle algorithm.\n\n" +
                "4. Click the 'Reset' button to clear the canvas and input fields.\n\n" +
                "5. Click the 'Back' button to return to the main menu.\n\n" +
                "💡 The circle is drawn symmetrically using the 8-way symmetry principle, and each pixel is displayed one by one.";

            MessageBox.Show(message, "Bresenham Circle Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
