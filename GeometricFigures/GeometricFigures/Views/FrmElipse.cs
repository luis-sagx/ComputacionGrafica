using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricFigures
{
    public partial class FrmElipse : Form
    {
        private Elipse ObjElipse = new Elipse();
        public FrmElipse()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void FrmElipse_Load(object sender, EventArgs e)
        {
            ObjElipse.InitializeData(txtSemiMajorAxis, txtSemiMinorAxis, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjElipse.ReadData(txtSemiMajorAxis, txtSemiMinorAxis);
            ObjElipse.CalculatePerimeter();
            ObjElipse.CalculateArea();
            ObjElipse.PrintData(txtPerimeter, txtArea);
            ObjElipse.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjElipse.InitializeData(txtSemiMajorAxis, txtSemiMinorAxis, txtPerimeter, txtArea, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }

    }
}
