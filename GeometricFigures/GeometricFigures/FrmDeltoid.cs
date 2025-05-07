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
    public partial class FrmDeltoid : Form
    {
        private Deltoid ObjDeltoid = new Deltoid();
        public FrmDeltoid()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void FrmDeltoid_Load(object sender, EventArgs e)
        {
            ObjDeltoid.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjDeltoid.ReadData(txtMajorDiagonal, txtMinorDiagonal, txtSideA, txtSideB);
            ObjDeltoid.CalculatePerimeter();
            ObjDeltoid.CalculateArea();
            ObjDeltoid.PrintData(txtPerimeter, txtArea);
            ObjDeltoid.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDeltoid.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
