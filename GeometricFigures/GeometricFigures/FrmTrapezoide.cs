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
    public partial class FrmTrapezoide : Form
    {
        private Trapezoide ObjTrapezoide = new Trapezoide();
        public FrmTrapezoide()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void FrmTrapezoide_Load(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtMajorBase, txtMinorBase, txtHeight, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.ReadData(txtMajorBase, txtMinorBase, txtHeight, txtSideA, txtSideB);
            ObjTrapezoide.CalculatePerimeter();
            ObjTrapezoide.CalculateArea();
            ObjTrapezoide.PrintData(txtPerimeter, txtArea);
            ObjTrapezoide.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapezoide.InitializeData(txtMajorBase, txtMinorBase, txtHeight, txtSideA, txtSideB, txtPerimeter, txtArea, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
