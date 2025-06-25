using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Domain.Abstract
{
    public abstract class CircleAlgorithm : AlgorithmCalculator
    {
        public Point Center = new Point();
        public int Radius { get; protected set; }

        public void ReadData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadius)
        {
            if (!int.TryParse(txtCenterX.Text, out int centerX) || centerX < -100 || centerX > 100)
            {
                MessageBox.Show("Enter a valid integer between -100 and 100 for X coordinate", "Error");
                txtCenterX.Focus();
                txtCenterX.SelectAll();
                return;
            }

            if (!int.TryParse(txtCenterY.Text, out int centerY) || centerY < -100 || centerY > 100)
            {
                MessageBox.Show("Enter a valid integer between -100 and 100 for Y coordinate", "Error");
                txtCenterY.Focus();
                txtCenterY.SelectAll();
                return;
            }

            if (!int.TryParse(txtRadius.Text, out int radius) || radius < 1 || radius > 150)
            {
                MessageBox.Show("Enter a positive integer between 1 and 150 for radius", "Error");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            Center.X = centerX;
            Center.Y = centerY;
            Radius = radius;
        }

        public void InitializeData(TextBox txtCenterX, TextBox txtCenterY, TextBox txtRadius,
                                  PictureBox picCanvas, DataGridView dgv = null)
        {
            Center = new Point();
            Radius = 0;

            txtCenterX.Text = txtCenterY.Text = txtRadius.Text = "";
            txtCenterX.Focus();
            picCanvas.Refresh();
            dgv?.Rows.Clear();
        }
    }
}