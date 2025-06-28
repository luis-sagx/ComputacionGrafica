using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sagnay_Luis_Leccion2
{
    public partial class FrmClock : Form
    {
        private ClockDrawer reloj;

        public FrmClock()
        {
            InitializeComponent();
        }

        private void FrmClock_Load(object sender, EventArgs e)
        {
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            reloj = new ClockDrawer(picCanvas);
        }

        private void picCanvas_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
    }
}
