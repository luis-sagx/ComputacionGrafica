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
    public partial class FrmSemicircle : Form
    {
        SemiCircle ObjSemiCircle = new SemiCircle();
        public FrmSemicircle()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }
        private void FrmSemicircle_Load(object sender, EventArgs e)
        {
            ObjSemiCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSemiCircle.ReadData(txtRadius);
            ObjSemiCircle.CalculatePerimeter();
            ObjSemiCircle.CalculateArea();
            ObjSemiCircle.PrintData(txtPerimeter, txtArea);
            ObjSemiCircle.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSemiCircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
