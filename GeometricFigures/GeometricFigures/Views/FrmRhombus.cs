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
    public partial class FrmRhombus : Form
    {
        private Rhombus ObjRhombus = new Rhombus();
        public FrmRhombus()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }
        private void FrmRhombus_Load(object sender, EventArgs e)
        {
            ObjRhombus.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRhombus.ReadData(txtMajorDiagonal, txtMinorDiagonal);
            ObjRhombus.CalculatePerimeter();
            ObjRhombus.CalculateArea();
            ObjRhombus.PrintData(txtPerimeter, txtArea);
            ObjRhombus.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRhombus.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
