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
    }
}
