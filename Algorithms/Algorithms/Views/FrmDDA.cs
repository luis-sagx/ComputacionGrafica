﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms.Algorithm;

namespace Algorithms.Views
{
    public partial class FrmDDA : Form
    {
        private DDAAlgorithm objAlgoritmoDDA = new DDAAlgorithm();
        public FrmDDA()
        {
            InitializeComponent();
        }

        private void FrmDDA_Load(object sender, EventArgs e)
        {
            objAlgoritmoDDA.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objAlgoritmoDDA.ReadData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy);
            objAlgoritmoDDA.Draw(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objAlgoritmoDDA.InitializeData(txtPuntoxi, txtPuntoyi, txtPuntox, txtPuntoy, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            objAlgoritmoDDA.CloseForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Close();
        }
    }
}
