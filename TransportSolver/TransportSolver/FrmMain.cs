using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportSolver.Methods;

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
            cmbMethod.Items.Add("Metoda minimalnih troškova");

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
            ResetResultLabel();
        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.ColumnCount = (int)nudColumns.Value;
            SetupDgvMatrixCellSize();
            UpdateMatrixSizeLabel(dgvMatrix.RowCount, dgvMatrix.ColumnCount);
            ResetResultLabel();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string result = "Z = ?";
                int rows = dgvMatrix.Rows.Count;
                int cols = dgvMatrix.Columns.Count;

                object[,] matrix = new object[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = dgvMatrix.Rows[i].Cells[j].Value;
                    }
                }

                if (cmbMethod.SelectedItem == "Metoda sjeverozapadnog kuta")
                {
                    result = NorthwestCornerMethod.NorthWestCornerCalculator(matrix, txtOutputCapacity.Text, txtDestinationNeeds.Text, txtSolutionSteps);
                }else if(cmbMethod.SelectedItem == "Metoda minimalnih troškova")
                {
                    result = MinimumCostMethod.MinimumCostCalculator(matrix, txtOutputCapacity.Text, txtDestinationNeeds.Text, txtSolutionSteps);
                }

                lblResult.Text = result;
            }
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(txtDestinationNeeds.Text) || string.IsNullOrWhiteSpace(txtOutputCapacity.Text))
            {
                MessageBox.Show("Polja za potrebe odredišta i kapacitet dobavljača moraju biti popunjena.", "Pogreška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string uzorak = @"^[0-9,\s]+$";
            if (!Regex.IsMatch(txtDestinationNeeds.Text, uzorak) || !Regex.IsMatch(txtOutputCapacity.Text, uzorak))
            {
                MessageBox.Show("Unosi moraju sadržavati samo brojeve i zareze.", "Pogreška unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ResetResultLabel()
        {
            lblResult.Text = "Z = ?";
        }

        private void dgvMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ResetResultLabel();
        }

        private void txtOutputCapacity_TextChanged(object sender, EventArgs e)
        {
            ResetResultLabel();
        }

        private void txtDestinationNeeds_TextChanged(object sender, EventArgs e)
        {
            ResetResultLabel();
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetResultLabel();
        }

    }
}
