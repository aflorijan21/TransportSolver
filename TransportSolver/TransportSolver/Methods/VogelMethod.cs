using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransportSolver.Methods
{
    public static class VogelMethod
    {
        public static string VogelCalculator(object[,] matrica, string izlazniKapacitet, string potrebeOdredista, TextBox txtKoraciRjesavanja, DataGridView dgvMatrix)
        {
            int[] kapaciteti = Array.ConvertAll(izlazniKapacitet.Split(','), int.Parse);
            int[] potrebe = Array.ConvertAll(potrebeOdredista.Split(','), int.Parse);

            int brojRedaka = matrica.GetLength(0);
            int brojStupaca = matrica.GetLength(1);

            if (kapaciteti.Sum() != potrebe.Sum())
            {
                return "Suma kapaciteta mora biti jednaka sumi potreba.";
            }

            int ukupniTrosak = 0;
            StringBuilder rezultat = new StringBuilder();
            txtKoraciRjesavanja.Clear();
            txtKoraciRjesavanja.AppendText("Koraci rješavanja transportnog problema Vogelovom metodom:\r\n");

            int rang = kapaciteti.Length + potrebe.Length - 1; // r = m + n - 1
            int zauzetaPolja = 0;

            while (kapaciteti.Sum() > 0 && potrebe.Sum() > 0)
            {
                int[] redovniPenali = new int[brojRedaka];
                for (int i = 0; i < brojRedaka; i++)
                {
                    var aktivneKolone = Enumerable.Range(0, brojStupaca).Where(j => potrebe[j] > 0).ToArray();
                    if (aktivneKolone.Length >= 2)
                    {
                        int min1 = int.MaxValue, min2 = int.MaxValue;
                        foreach (var j in aktivneKolone)
                        {
                            int trenutniTrosak = Convert.ToInt32(matrica[i, j]);
                            if (trenutniTrosak < min1)
                            {
                                min2 = min1;
                                min1 = trenutniTrosak;
                            } else if (trenutniTrosak < min2)
                            {
                                min2 = trenutniTrosak;
                            }
                        }
                        redovniPenali[i] = min2 - min1;
                    }
                }

                int[] stupcaniPenali = new int[brojStupaca];
                for (int j = 0; j < brojStupaca; j++)
                {
                    var aktivniRedci = Enumerable.Range(0, brojRedaka).Where(i => kapaciteti[i] > 0).ToArray();
                    if (aktivniRedci.Length >= 2)
                    {
                        int min1 = int.MaxValue, min2 = int.MaxValue;
                        foreach (var i in aktivniRedci)
                        {
                            int trenutniTrosak = Convert.ToInt32(matrica[i, j]);
                            if (trenutniTrosak < min1)
                            {
                                min2 = min1;
                                min1 = trenutniTrosak;
                            } else if (trenutniTrosak < min2)
                            {
                                min2 = trenutniTrosak;
                            }
                        }
                        stupcaniPenali[j] = min2 - min1;
                    }
                }

                int maxPenal = -1;
                int odabraniRedak = -1, odabraniStupac = -1;

                for (int i = 0; i < brojRedaka; i++)
                {
                    if (kapaciteti[i] > 0 && redovniPenali[i] > maxPenal)
                    {
                        maxPenal = redovniPenali[i];
                        odabraniRedak = i;
                        odabraniStupac = -1;
                    }
                }

                for (int j = 0; j < brojStupaca; j++)
                {
                    if (potrebe[j] > 0 && stupcaniPenali[j] > maxPenal)
                    {
                        maxPenal = stupcaniPenali[j];
                        odabraniRedak = -1;
                        odabraniStupac = j;
                    }
                }

                if (odabraniRedak == -1 && odabraniStupac == -1)
                {
                    break;
                }

                if (odabraniRedak != -1)
                {
                    odabraniStupac = Enumerable.Range(0, brojStupaca).Where(j => potrebe[j] > 0).OrderBy(j => Convert.ToInt32(matrica[odabraniRedak, j])).First();
                } else
                {
                    odabraniRedak = Enumerable.Range(0, brojRedaka).Where(i => kapaciteti[i] > 0).OrderBy(i => Convert.ToInt32(matrica[i, odabraniStupac])).First();
                }

                int kolicina = Math.Min(kapaciteti[odabraniRedak], potrebe[odabraniStupac]);
                int trosak = Convert.ToInt32(matrica[odabraniRedak, odabraniStupac]);

                kapaciteti[odabraniRedak] -= kolicina;
                potrebe[odabraniStupac] -= kolicina;
                ukupniTrosak += kolicina * trosak;

                rezultat.Append($"{kolicina}*{trosak} + ");
                txtKoraciRjesavanja.AppendText($"Transport {kolicina} jedinica od dobavljača {odabraniRedak + 1} do odredišta {odabraniStupac + 1} po cijeni {trosak}.\n");
                txtKoraciRjesavanja.AppendText(Environment.NewLine);

                dgvMatrix.Rows[odabraniRedak].Cells[odabraniStupac].Style.BackColor = System.Drawing.Color.LightGray;
                zauzetaPolja++;
            }

            // Degeneracija
            while (zauzetaPolja < rang)
            {
                bool dodanaFiktivnaRelacija = false;
                for (int x = 0; x < brojRedaka; x++)
                {
                    for (int y = 0; y < brojStupaca; y++)
                    {
                        if (dgvMatrix.Rows[x].Cells[y].Style.BackColor != System.Drawing.Color.LightGray)
                        {
                            dgvMatrix.Rows[x].Cells[y].Style.BackColor = System.Drawing.Color.Yellow;
                            zauzetaPolja++;
                            dodanaFiktivnaRelacija = true;
                            rezultat.Append("0*0 + ");
                            txtKoraciRjesavanja.AppendText($"Dodavanje fiktivne relacije na poziciju ({x + 1},{y + 1}) s nulom.\n");
                            txtKoraciRjesavanja.AppendText(Environment.NewLine);
                            break;
                        }
                    }
                    if (dodanaFiktivnaRelacija)
                    {
                        break;
                    }
                }
            }

            if (rezultat.Length > 3)
            {
                rezultat.Length -= 3;
            }
            rezultat.Append($" = {ukupniTrosak}");
            txtKoraciRjesavanja.AppendText($"Ukupni trošak je {ukupniTrosak}.\n");

            return rezultat.ToString();
        }
    }
}
