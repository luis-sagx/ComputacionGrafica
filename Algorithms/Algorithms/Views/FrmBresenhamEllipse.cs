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
    }
}
