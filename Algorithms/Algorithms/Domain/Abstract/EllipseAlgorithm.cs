using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Domain.Abstract
{
    public abstract class EllipseAlgorithm : AlgorithmCalculator
    {
        public Point Center = new Point();
        public int Rx { get; protected set; }
        public int Ry { get; protected set; }

        public void ReadData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRx, TextBox txtRy = null)
        {
            if (!int.TryParse(txtCenterX.Text, out int cx) || cx < -100 || cx > 100)
            {
                ShowError("X", txtCenterX); return;
            }

            if (!int.TryParse(txtCenterY.Text, out int cy) || cy < -100 || cy > 100)
            {
                ShowError("Y", txtCenterY); return;
            }

            if (!int.TryParse(txtRx.Text, out int rx) || rx < 1 || rx > 150)
            {
                ShowError("Rx", txtRx); return;
            }

            int ry = rx;
            if (txtRy != null)
            {
                if (!int.TryParse(txtRy.Text, out ry) || ry < 1 || ry > 150)
                {
                    ShowError("Ry", txtRy); return;
                }
            }

            Center.X = cx;
            Center.Y = cy;
            Rx = rx;
            Ry = ry;
        }

        public void InitializeData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRx, TextBox txtRy,
                                   PictureBox picCanvas)
        {
            Center = new Point();
            Rx = Ry = 0;

            txtCenterX.Text = txtCenterY.Text = txtRx.Text = txtRy.Text = "";
            txtCenterX.Focus();
            picCanvas.Refresh();
        }

        private void ShowError(string field, TextBox txt)
        {
            MessageBox.Show($"Enter a valid number {field} (between -100 and 100 for coordinates, between 1 and 150 for radius).", "Error"); txt.Focus();
            txt.SelectAll();
        }
    }
}