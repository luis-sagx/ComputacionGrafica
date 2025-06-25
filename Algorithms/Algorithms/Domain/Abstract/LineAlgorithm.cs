using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Domain.Abstract
{
    public abstract class LineAlgorithm : AlgorithmCalculator
    {
        public Point StartPoint = new Point();
        public Point EndPoint = new Point();

        public void ReadData(TextBox txtStartX, TextBox txtStartY, TextBox txtEndX, TextBox txtEndY)
        {
            try
            {
                StartPoint.X = int.Parse(txtStartX.Text);
                StartPoint.Y = int.Parse(txtStartY.Text);
                EndPoint.X = int.Parse(txtEndX.Text);
                EndPoint.Y = int.Parse(txtEndY.Text);

                if (Math.Abs(StartPoint.X) > 150 || Math.Abs(StartPoint.Y) > 150 ||
                    Math.Abs(EndPoint.X) > 150 || Math.Abs(EndPoint.Y) > 150)
                {
                    MessageBox.Show("Coordinates must be between - 150 and 150", "Range error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StartPoint = new Point();
                    EndPoint = new Point();
                    txtStartX.Focus();
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, Enter de valid values", "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStartX.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InitializeData(TextBox txtStartX, TextBox txtStartY, TextBox txtEndX, TextBox txtEndY,
                                 PictureBox picCanvas)
        {
            StartPoint = new Point();
            EndPoint = new Point();
            txtStartX.Text = txtEndX.Text = "";
            txtStartY.Text = txtEndY.Text = "";
            txtStartX.Focus();
            picCanvas.Refresh();
        }
    }
}
