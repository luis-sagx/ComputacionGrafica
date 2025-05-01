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
    public partial class FrmSquare : Form
    {

        private Square ObjSquare = new Square();
        public FrmSquare()
        {
            InitializeComponent();
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSize, txtPerimeter, txtArea, picCanvas);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtSize);
            ObjSquare.PerimeterRectangle();
            ObjSquare.AreaRectangle();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            ObjSquare.PlotShape(picCanvas);
        }

        private void btnReset_Click(Object sendser, EventArgs e)
        {
            ObjSquare.InitializeData(txtSize, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(Object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

    }
}
