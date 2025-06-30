using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDDA().Show();
            Hide();
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBresenhamLine().Show();
            Hide();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBresenhamCircle().Show();
            Hide();
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBresenhamEllipse().Show();
            Hide();
        }

        private void floodFillRecursiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmFloodFill().Show();
            Hide();
        }

        private void lineClippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCohenSutherland().Show();
            Hide();
        }

        private void polygonClippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSutherlandHodgman().Show();
            Hide();
        }

        private void bezierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCurves().Show();
            Hide();
        }

    }
}
