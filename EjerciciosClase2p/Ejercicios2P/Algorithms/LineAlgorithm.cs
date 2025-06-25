using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios2P.Domain.Models;
using Ejercicios2P.Models;

namespace Ejercicios2P.Algorithms.Line
{
    public abstract class LineAlgorithm : AlgorithmCalculator
    {
        public Point2D StartPoint { get; protected set; } = new Point2D();
        public Point2D EndPoint { get; protected set; } = new Point2D();

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
                    StartPoint = new Point2D();
                    EndPoint = new Point2D();
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
                                 PictureBox picCanvas, DataGridView dgv = null)
        {
            StartPoint = new Point2D();
            EndPoint = new Point2D();
            txtStartX.Text = txtEndX.Text = "";
            txtStartY.Text = txtEndY.Text = "";
            txtStartX.Focus();
            picCanvas.Refresh();
            dgv?.Rows.Clear();
        }
    }
}
