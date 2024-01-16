using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului (sortate in ordine crescatoare):");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Introduceti elementul pentru cautare: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int pozitie = CautareBinara(vector, n, k);

            if (pozitie != -1)
            {
                Console.WriteLine($"Elementul {k} se gaseste la pozitia {pozitie} in vector.");
            }
            else
            {
                Console.WriteLine($"Elementul {k} nu se gaseste in vector.");
            }
        }

        static int CautareBinara(int[] vector, int n, int k)
        {
            int stanga = 0;
            int dreapta = n - 1;

            while (stanga <= dreapta)
            {
                int mijloc = stanga + (dreapta - stanga) / 2;

                if (vector[mijloc] == k)
                {
                    return mijloc; 
                }
                else if (vector[mijloc] < k)
                {
                    stanga = mijloc + 1; 
                }
                else
                {
                    dreapta = mijloc - 1; 
                }
            }

            return -1; 
        }
    }
}

