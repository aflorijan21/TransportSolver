using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportSolver.Methods
{
    public static class NorthwestCornerMethod
    {
        public static string NorthWestCornerCalculator(object[,] matrix, string outputCapacity, string destinationNeeds, TextBox txtSolutionSteps, DataGridView dgvMatrix)
        {
            int[] kapaciteti = Array.ConvertAll(outputCapacity.Split(','), int.Parse);
            int[] potrebe = Array.ConvertAll(destinationNeeds.Split(','), int.Parse);

            int i = 0, j = 0;

            if (kapaciteti.Sum() != potrebe.Sum())
            {
                return "Suma kapaciteta mora biti jednaka sumi potreba.";
            }

            StringBuilder result = new StringBuilder();
            int ukupniTrosak = 0;

            txtSolutionSteps.Clear();
            txtSolutionSteps.AppendText("Koraci rješavanja transportnog problema metodom sjeverozapadnog kuta:\r\n");

            int rang = kapaciteti.Length + potrebe.Length - 1; // r = m + n - 1
            int zauzetaPolja = 0;

            while (i < kapaciteti.Length && j < potrebe.Length)
            {
                int quantity = Math.Min(kapaciteti[i], potrebe[j]);
                int cost = Convert.ToInt32(matrix[i, j]);

                result.Append($"{quantity}*{cost} + ");

                txtSolutionSteps.AppendText($"Transport {quantity} jedinica od dobavljača {i + 1} do odredišta {j + 1} po cijeni {cost}.\n");

                txtSolutionSteps.AppendText(Environment.NewLine);

                ukupniTrosak += quantity * cost;

                kapaciteti[i] -= quantity;
                potrebe[j] -= quantity;

                dgvMatrix.Rows[i].Cells[j].Style.BackColor = Color.LightGray;

                zauzetaPolja++;

                if (kapaciteti[i] == 0)
                {
                    i++;
                }

                if (potrebe[j] == 0)
                {
                    j++;
                }
            }

            // Degeneracija
            while (zauzetaPolja < rang)
            {              
                bool dodanaFiktivnaRelacija = false;
                for (int x = 0; x < kapaciteti.Length; x++)
                {
                    for (int y = 0; y < potrebe.Length; y++)
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

            if (result.Length > 3)
            {
                result.Length -= 3;
            }
            result.Append($" = {ukupniTrosak}");

            txtSolutionSteps.AppendText($"Ukupni trošak je {ukupniTrosak}.\n");

            return result.ToString();
        }
    }
}
