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
    public partial class FrmRhomboid : Form
    {
        private Rhomboid ObjRhomboid = new Rhomboid();
        public FrmRhomboid()
        {
            InitializeComponent();
            txtArea.ReadOnly = true;
            txtPerimeter.ReadOnly = true;
        }

        private void FrmRhomboid_Load(object sender, EventArgs e)
        {
            ObjRhomboid.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRhomboid.ReadData(txtWidth, txtHeight);
            ObjRhomboid.CalculatePerimeter();
            ObjRhomboid.CalculateArea();
            ObjRhomboid.PrintData(txtPerimeter, txtArea);
            ObjRhomboid.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRhomboid.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
