using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportSolver
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillCmbMethod();
            SetupDgvMatrix();
        }

        private void FillCmbMethod()
        {
            cmbMethod.Items.Add("Metoda sjeverozapadnog kuta");
            cmbMethod.SelectedItem = "Metoda sjeverozapadnog kuta";
        }

        private void SetupDgvMatrix()
        {
            dgvMatrix.RowCount = 3;
            dgvMatrix.ColumnCount = 3;

            SetupDgvMatrixCellSize();


        }

        private void UpdateMatrixSizeLabel(int rows, int columns)
        {
            lblMatrixSize.Text = rows + "x" + columns;
        }

        private void SetupDgvMatrixCellSize()
        {
            int desiredWidth = 75;
            int desiredHeight = 75;

            foreach (DataGridViewColumn column in dgvMatrix.Columns)
            {
                column.Width = desiredWidth;
            }

            foreach (DataGridViewRow row in dgvMatrix.Rows)
            {
                row.Height = desiredHeight;
            }
        }

        private void nudRows_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.RowCount = (int)nudRows.Value;
            SetupDgvMatrixCellSize();
            UpdateMatrixSizeLabel(dgvMatrix.RowCount, dgvMatrix.ColumnCount);
        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.ColumnCount = (int)nudColumns.Value;
            SetupDgvMatrixCellSize();
            UpdateMatrixSizeLabel(dgvMatrix.RowCount, dgvMatrix.ColumnCount);
        }
       
    }
}
