using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            SortareZeroLaSfarsit(vector, n);

            Console.WriteLine("Vectorul dupa sortarea zero-urilor la sfarsit:");
            AfisareVector(vector, n);
        }

        static void SortareZeroLaSfarsit(int[] vector, int n)
        {
            int pozitieZero = n - 1;

            for (int i = n - 1; i >= 0; i--)
            {
                if (vector[i] != 0)
                {
                    vector[pozitieZero] = vector[i];
                    pozitieZero--;
                }
            }
            while (pozitieZero >= 0)
            {
                vector[pozitieZero] = 0;
                pozitieZero--;
            }
        }

        static void AfisareVector(int[] vector, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
    

