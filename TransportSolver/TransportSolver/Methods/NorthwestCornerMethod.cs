using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportSolver.Methods
{
    public static class NorthwestCornerMethod
    {
        public static string NorthWestCornerCalculator(object[,] matrix, string outputCapacity, string destinationNeeds, TextBox txtSolutionSteps)
        {
            int[] capacities = Array.ConvertAll(outputCapacity.Split(','), int.Parse);
            int[] needs = Array.ConvertAll(destinationNeeds.Split(','), int.Parse);

            int i = 0, j = 0;

            StringBuilder result = new StringBuilder();
            int totalCost = 0;

            txtSolutionSteps.Clear();

            while (i < capacities.Length && j < needs.Length)
            {
                int quantity = Math.Min(capacities[i], needs[j]);
                int cost = Convert.ToInt32(matrix[i, j]);

                result.Append($"{quantity}*{cost} + ");

                txtSolutionSteps.AppendText($"Transport {quantity} jedinica od dobavljača {i + 1} do odredišta {j + 1} po cijeni {cost}.\n");

                txtSolutionSteps.AppendText(Environment.NewLine);

                totalCost += quantity * cost;

                capacities[i] -= quantity;
                needs[j] -= quantity;

                if (capacities[i] == 0)
                {
                    i++;
                }

                if (needs[j] == 0)
                {
                    j++;
                }
            }

            if (result.Length > 3)
            {
                result.Length -= 3;
            }
            result.Append($" = {totalCost}");

            txtSolutionSteps.AppendText($"Ukupni trošak je {totalCost}.\n");

            return result.ToString();
        }
    }
}
