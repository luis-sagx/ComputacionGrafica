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
    public partial class FrmTriangle : Form
    {
        private Triangle ObjTriangle = new Triangle();
        public FrmTriangle()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            ObjTriangle.CalculatePerimeter();
            ObjTriangle.CalculateArea();
            ObjTriangle.PrintData(txtPerimeter, txtArea);
            ObjTriangle.PlotShape(picCanvas);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtPerimeter, txtArea, picCanvas);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //ObjTriangle.CloseForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
