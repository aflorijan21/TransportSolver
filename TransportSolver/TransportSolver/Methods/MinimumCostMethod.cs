using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportSolver.Methods
{
    public static class MinimumCostMethod
    {
        public static string MinimumCostCalculator(object[,] matrix, string outputCapacity, string destinationNeeds, TextBox txtSolutionSteps)
        {
            int[] kapaciteti = Array.ConvertAll(outputCapacity.Split(','), int.Parse);
            int[] potrebe = Array.ConvertAll(destinationNeeds.Split(','), int.Parse);

            int brojRedaka = matrix.GetLength(0);
            int brojStupaca = matrix.GetLength(1);

            if (kapaciteti.Sum() != potrebe.Sum())
            {
                return "Suma kapaciteta mora biti jednaka sumi potreba.";
            }

            int[,] rjesenje = new int[brojRedaka, brojStupaca];

            int[] preostaliKapaciteti = (int[])kapaciteti.Clone();
            int[] preostalePotrebe = (int[])potrebe.Clone();

            int ukupniTrosak = 0;

            StringBuilder result = new StringBuilder();
            txtSolutionSteps.Clear();
            txtSolutionSteps.AppendText("Koraci rješavanja transportnog problema metodom minimalnih troškova:\r\n");

            while (Array.Exists(preostaliKapaciteti, c => c > 0) && Array.Exists(preostalePotrebe, d => d > 0))
            {
                int minTrosak = int.MaxValue;
                int minRedak = -1;
                int minStupac = -1;

                for (int i = 0; i < brojRedaka; i++)
                {
                    for (int j = 0; j < brojStupaca; j++)
                    {
                        int trosak = Convert.ToInt32(matrix[i, j]);
                        if (trosak < minTrosak && preostaliKapaciteti[i] > 0 && preostalePotrebe[j] > 0)
                        {
                            minTrosak = trosak;
                            minRedak = i;
                            minStupac = j;
                        }
                    }
                }

                int kolicina = Math.Min(preostaliKapaciteti[minRedak], preostalePotrebe[minStupac]);

                rjesenje[minRedak, minStupac] = kolicina;
                preostaliKapaciteti[minRedak] -= kolicina;
                preostalePotrebe[minStupac] -= kolicina;
                ukupniTrosak += kolicina * minTrosak;

                result.Append($"{kolicina}*{minTrosak} + ");
                txtSolutionSteps.AppendText($"Prevezeno {kolicina} jedinica iz {minRedak + 1}. ishodišta u {minStupac + 1}. odredište po trošku {minTrosak}.\n");
                txtSolutionSteps.AppendText(Environment.NewLine);
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
