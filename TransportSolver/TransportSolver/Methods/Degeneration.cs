using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TransportSolver.Methods
{
    public static class Degeneration
    {
        public static void SolveDegeneration(DataGridView dgvMatrix, ref int zauzetaPolja, int rang, TextBox txtSolutionSteps, StringBuilder result)
        {
            while (zauzetaPolja < rang)
            {
                bool dodanaFiktivnaRelacija = false;
                for (int x = 0; x < dgvMatrix.RowCount; x++)
                {
                    for (int y = 0; y < dgvMatrix.ColumnCount; y++)
                    {
                        if (dgvMatrix.Rows[x].Cells[y].Style.BackColor != Color.LightGray)
                        {
                            dgvMatrix.Rows[x].Cells[y].Style.BackColor = Color.Yellow;
                            zauzetaPolja++;
                            dodanaFiktivnaRelacija = true;
                            result.Append("0*0 + ");
                            txtSolutionSteps.AppendText($"Dodavanje fiktivne relacije na poziciju ({x + 1},{y + 1}) s nulom.\n");
                            txtSolutionSteps.AppendText(Environment.NewLine);
                            break;
                        }
                    }
                    if (dodanaFiktivnaRelacija)
                    {
                        break;
                    }
                }
            }
        }
    }
}
