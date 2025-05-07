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
    public partial class FrmTrapezoid : Form
    {
        private Trapezoid ObjTrapezoid = new Trapezoid();
        public FrmTrapezoid()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {
            ObjTrapezoid.InitializeData(txtMajorBase, txtMinorBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTrapezoid.ReadData(txtMajorBase, txtMinorBase, txtHeight);
            ObjTrapezoid.CalculatePerimeter();
            ObjTrapezoid.CalculateArea();
            ObjTrapezoid.PrintData(txtPerimeter, txtArea);
            ObjTrapezoid.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapezoid.InitializeData(txtMajorBase, txtMinorBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
