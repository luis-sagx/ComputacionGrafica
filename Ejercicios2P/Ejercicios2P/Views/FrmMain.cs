using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios2P.Bresenham;
using Ejercicios2P.DDA;
using Ejercicios2P.DrawCircle;

namespace Ejercicios2P.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lineWithDDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDDA().Show();
            Hide();
        }

        private void lineWithBresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBresenham().Show();
            Hide();
        }

        private void cicleWithBresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCirculo().Show();
            Hide();
        }

        private void drawAndFillPoligonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmFloodFill().Show();
            Hide();
        }
    }
}
