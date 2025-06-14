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

    public partial class FrmPythagorean : Form
    {

        private PythagoreanMan ObjPythagoreanMan = new PythagoreanMan();
        public FrmPythagorean()
        {
            InitializeComponent();
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            ObjPythagoreanMan.InitializeData(txtRadius, picCanvas);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjPythagoreanMan.ReadData(txtRadius);
            ObjPythagoreanMan.PlotShape(picCanvas);
        }

        private void btnReset_Click(Object sendser, EventArgs e)
        {
            ObjPythagoreanMan.InitializeData(txtRadius, picCanvas);
        }

        private void btnExit_Click(Object sender, EventArgs e)
        {
            ObjPythagoreanMan.CloseForm(this);
        }

    }
}
