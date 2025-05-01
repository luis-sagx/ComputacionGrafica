using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure_1
{
    public partial class FrmRectangle : Form
    {
        
        private Rectangle ObjRectangle = new Rectangle();
        public FrmRectangle()
        {
            InitializeComponent();
        }
        private void FrmRectangle_Load_1(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            ObjRectangle.ReadData(txtWidth, txtHeight);
            ObjRectangle.PerimeterRectangle();
            ObjRectangle.AreaRectangle();
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            ObjRectangle.PlotShape(picCanvas);
        }

        private void btnReset_Click(Object sendser, EventArgs e) {
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(Object sender, EventArgs e) {
            ObjRectangle.CloseForm(this);
        }
    }
}
