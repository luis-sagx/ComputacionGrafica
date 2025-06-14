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
    public partial class FrmTrinity : Form
    {
        private Trinity objTrinity = new Trinity();

        public FrmTrinity()
        {
            InitializeComponent();
            this.Text = "Figura Geométrica Sagrada de la Trinidad";
            this.BackColor = Color.WhiteSmoke;
        }

        private void FrmTrinity_Load(object sender, EventArgs e)
        {
            objTrinity.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTrinity.ReadData(txtSide);
            objTrinity.CalculatePerimeter();
            objTrinity.CalculateArea();
            objTrinity.PrintData(txtPerimeter, txtArea);
            objTrinity.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objTrinity.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objTrinity.CloseForm(this);
        }

        private void FrmTrinity_FormClosing(object sender, FormClosingEventArgs e)
        {
            objTrinity.Dispose();
        }

        // Evento para redibujar cuando se redimensiona la ventana
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSide.Text))
            {
                objTrinity.PlotShape(picCanvas);
            }
        }
    }
}
