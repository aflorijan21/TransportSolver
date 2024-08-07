using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportSolver.Methods
{
    public static class NorthwestCornerMethod
    {
        public static string NorthWestCornerCalculator(object[,] matrix, string outputCapacity, string destinationNeeds)
        {
            int[] capacities = Array.ConvertAll(outputCapacity.Split(','), int.Parse);
            int[] needs = Array.ConvertAll(destinationNeeds.Split(','), int.Parse);

            int i = 0, j = 0;

            StringBuilder result = new StringBuilder();
            int totalCost = 0;

            while (i < capacities.Length && j < needs.Length)
            {
                int quantity = Math.Min(capacities[i], needs[j]);
                int cost = Convert.ToInt32(matrix[i, j]);

                result.Append($"{quantity}*{cost} + ");

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

            return result.ToString();
        }
    }
}
