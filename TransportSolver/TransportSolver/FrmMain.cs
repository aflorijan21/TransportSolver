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
            cmbMethod.Items.Add("Vogel-ova metoda");
            cmbMethod.Items.Add("MODI Metoda");

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
            lblMatrixSize.Text = columns + "x" + rows;
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
            ResetDgvMatrixCellColors();
            txtSolutionSteps.Clear();
        }

        private void nudColumns_ValueChanged(object sender, EventArgs e)
        {
            dgvMatrix.ColumnCount = (int)nudColumns.Value;
            SetupDgvMatrixCellSize();
            UpdateMatrixSizeLabel(dgvMatrix.RowCount, dgvMatrix.ColumnCount);
            ResetResultLabel();
            ResetDgvMatrixCellColors();
            txtSolutionSteps.Clear();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
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

                if (cmbMethod.SelectedItem.ToString() == "Metoda sjeverozapadnog kuta")
                {
                    result = NorthwestCornerMethod.NorthWestCornerCalculator(matrix, txtOutputCapacity.Text, txtDestinationNeeds.Text, txtSolutionSteps, dgvMatrix);
                } else if (cmbMethod.SelectedItem.ToString() == "Metoda minimalnih troškova")
                {
                    result = MinimumCostMethod.MinimumCostCalculator(matrix, txtOutputCapacity.Text, txtDestinationNeeds.Text, txtSolutionSteps, dgvMatrix);
                } else if (cmbMethod.SelectedItem.ToString() == "Vogel-ova metoda")
                {
                    result = VogelMethod.VogelCalculator(matrix, txtOutputCapacity.Text, txtDestinationNeeds.Text, txtSolutionSteps, dgvMatrix);
                } else if (cmbMethod.SelectedItem.ToString() == "MODI Metoda")
                {
                    result = ModiMethod.ModiCalculator(matrix, txtOutputCapacity.Text, txtDestinationNeeds.Text, txtSolutionSteps);
                }

                lblResult.Text = result;
                dgvMatrix.ClearSelection();
            }
        }

        private bool ValidateInputs()
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

        private void ResetDgvMatrixCellColors()
        {
            foreach (DataGridViewRow row in dgvMatrix.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void dgvMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ResetResultLabel();
            ResetDgvMatrixCellColors();
            txtSolutionSteps.Clear();
        }

        private void txtOutputCapacity_TextChanged(object sender, EventArgs e)
        {
            ResetResultLabel();
            ResetDgvMatrixCellColors();
            txtSolutionSteps.Clear();
        }

        private void txtDestinationNeeds_TextChanged(object sender, EventArgs e)
        {
            ResetResultLabel();
            ResetDgvMatrixCellColors();
            txtSolutionSteps.Clear();
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetResultLabel();
            ResetDgvMatrixCellColors();
            txtSolutionSteps.Text = "";
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            txtOutputCapacity.Text = "45,50,90,45";
            txtDestinationNeeds.Text = "120,40,70";

            nudRows.Value = 4;
            nudColumns.Value = 3;

            int[,] matrix = new int[,]
            {
                { 5, 10, 15 },
                { 12, 4, 8 },
                { 7, 3, 9 },
                { 14, 16, 1 }
            };
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();

            dgvMatrix.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j].ToString();
                }
                dgvMatrix.Rows.Add(row);
            }

            SetupDgvMatrixCellSize();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();

            nudRows.Value = 0;
            nudColumns.Value = 0;

            txtOutputCapacity.Clear();
            txtDestinationNeeds.Clear();

            SetupDgvMatrixCellSize();
            ResetDgvMatrixCellColors();
        }

        private void btnExample2_Click(object sender, EventArgs e)
        {
            txtOutputCapacity.Text = "300,400,500";
            txtDestinationNeeds.Text = "250,350,400,200";

            nudRows.Value = 3;
            nudColumns.Value = 4;

            int[,] matrix = new int[,]
            {
                { 3,1,7,4 },
                { 2,6,5,9 },
                { 8,3,3,2 }
            };
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();

            dgvMatrix.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j].ToString();
                }
                dgvMatrix.Rows.Add(row);
            }

            SetupDgvMatrixCellSize();
        }

        private void btnDegeneracijaPrimjer_Click(object sender, EventArgs e)
        {
            txtOutputCapacity.Text = "50,90,60";
            txtDestinationNeeds.Text = "50,40,70,40";

            nudRows.Value = 3;
            nudColumns.Value = 4;

            int[,] matrix = new int[,]
            {
                { 2,5,4,5 },
                { 1,2,1,4 },
                { 3,1,5,2 }
            };
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();

            dgvMatrix.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j].ToString();
                }
                dgvMatrix.Rows.Add(row);
            }

            SetupDgvMatrixCellSize();
        }
    }
}
