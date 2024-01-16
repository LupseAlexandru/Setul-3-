using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] vector = new double[n];

            Console.WriteLine("Introduceti elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = Convert.ToDouble(Console.ReadLine());
            }

            GasestePozitiiMinMax(vector, n, out int pozitieMin, out int pozitieMax);

            Console.WriteLine($"Cel mai mic element se afla la pozitia {pozitieMin}.");
            Console.WriteLine($"Cel mai mare element se afla la pozitia {pozitieMax}.");
        }

        static void GasestePozitiiMinMax(double[] vector, int n, out int pozitieMin, out int pozitieMax)
        {
            pozitieMin = pozitieMax = 0;

            if (n > 1)
            {
                int i = 1;

                if (vector[0] > vector[1])
                {
                    pozitieMax = 0;
                    pozitieMin = 1;
                }
                else
                {
                    pozitieMax = 1;
                    pozitieMin = 0;
                }

                while (i < n - 1)
                {
                    if (vector[i] > vector[i + 1])
                    {
                        if (vector[i] > vector[pozitieMax])
                            pozitieMax = i;
                        if (vector[i + 1] < vector[pozitieMin])
                            pozitieMin = i + 1;
                    }
                    else
                    {
                        if (vector[i + 1] > vector[pozitieMax])
                            pozitieMax = i + 1;
                        if (vector[i] < vector[pozitieMin])
                            pozitieMin = i;
                    }

                    i += 2;
                }
            }
        }
    }
}   

