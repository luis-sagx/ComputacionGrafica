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
    public partial class FrmLines : Form
    {
        private Line objLine = new Line();
        public FrmLines()
        {
            InitializeComponent();
            picCanvas.Paint += picCanvas_Paint;
            picCanvas.MouseClick += picCanvas_mouseClick;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            objLine.Clear();
            picCanvas.Invalidate();
        }

        private void picCanvas_mouseClick(object sender, MouseEventArgs e)
        {
            objLine.AddPoint(new PointF(e.X, e.Y));
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            objLine.DrawAll(e.Graphics);
        }
    }

}
