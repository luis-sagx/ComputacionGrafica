using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios2P.Utils
{
    public class Table
    {
        public static void InicializarDataGridView(DataGridView dataGridViewPuntos)
        {
            dataGridViewPuntos.Columns.Clear();
            dataGridViewPuntos.Columns.Add("Pasos", "Paso");
            dataGridViewPuntos.Columns.Add("X", "X");
            dataGridViewPuntos.Columns.Add("Y", "Y");
            dataGridViewPuntos.Columns["Pasos"].Width = 85;
            dataGridViewPuntos.Columns["X"].Width = 70;
            dataGridViewPuntos.Columns["Y"].Width = 70;

            ConfigurarPropiedadesBasicas(dataGridViewPuntos);
        }

        public static void InicializarDataGridViewCirculo(DataGridView dataGridViewPuntos)
        {
            dataGridViewPuntos.Columns.Clear();
            dataGridViewPuntos.Columns.Add("Pasos", "Paso");
            dataGridViewPuntos.Columns.Add("X", "X");
            dataGridViewPuntos.Columns.Add("Y", "Y");
            dataGridViewPuntos.Columns.Add("P", "P (Decisión)");

            dataGridViewPuntos.Columns["Pasos"].Width = 60;
            dataGridViewPuntos.Columns["X"].Width = 50;
            dataGridViewPuntos.Columns["Y"].Width = 50;
            dataGridViewPuntos.Columns["P"].Width = 70;

            ConfigurarPropiedadesBasicas(dataGridViewPuntos);
            dataGridViewPuntos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private static void ConfigurarPropiedadesBasicas(DataGridView dataGridViewPuntos)
        {
            dataGridViewPuntos.AllowUserToAddRows = false;
            dataGridViewPuntos.AllowUserToDeleteRows = false;
            dataGridViewPuntos.ReadOnly = true;
            dataGridViewPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPuntos.RowHeadersVisible = false;
            dataGridViewPuntos.MultiSelect = false;
            dataGridViewPuntos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPuntos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
