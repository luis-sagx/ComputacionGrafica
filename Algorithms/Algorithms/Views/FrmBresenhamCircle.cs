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
    }
}
