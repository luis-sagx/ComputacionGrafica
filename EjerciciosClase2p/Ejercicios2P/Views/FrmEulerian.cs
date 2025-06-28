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
    public partial class FrmEulerian : Form
    {
        private EulerianFigure figuraActual;

        public FrmEulerian()
        {
            InitializeComponent();
        }

        private void btnHeptagram_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            figuraActual = StarFactory.CreateHeptagram();
            figuraActual.Draw(picCanvas);
        }

        private void btnEnneagram_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            figuraActual = StarFactory.CreateEnneagram();
            figuraActual.Draw(picCanvas);
        }

        private void btnDavid_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            figuraActual = StarFactory.CreateStarOfDavid();
            figuraActual.Draw(picCanvas);
        }

        private void btnPentagonStar_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            figuraActual = StarFactory.CreatePentagonWithStar();
            figuraActual.Draw(picCanvas);
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            figuraActual = StarFactory.CreateGridWithDiagonals();
            figuraActual.Draw(picCanvas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}