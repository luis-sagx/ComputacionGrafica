using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figure_1
{
    public partial class FrmFlorMargarita : Form
    {
        private FlorMargarita ObjFlorMargarita = new FlorMargarita();   
        public FrmFlorMargarita()
        {
            InitializeComponent();
        }

        private void FrmFlower_Load(object sender, EventArgs e)
        {
            ObjFlorMargarita.InitializeData(txtSize, picCanvas);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjFlorMargarita.ReadData(txtSize);
            ObjFlorMargarita.PlotShape(picCanvas);
        }

        private void btnReset_Click(Object sendser, EventArgs e)
        {
            ObjFlorMargarita.InitializeData(txtSize, picCanvas);
        }

    }
}
