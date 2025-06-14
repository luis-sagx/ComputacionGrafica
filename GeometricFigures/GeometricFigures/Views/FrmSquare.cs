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
    public partial class FrmSquare : Form
    {

        private Square ObjSquare = new Square();
        public FrmSquare()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtSide);
            ObjSquare.CalculatePerimeter();
            ObjSquare.CalculateArea();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            ObjSquare.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
