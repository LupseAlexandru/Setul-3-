using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_5
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

            Console.Write("Introduceti valoarea de inserat: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti pozitia de inserat: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k < 0 || k > n)
            {
                Console.WriteLine("Pozitia introdusa este invalida.");
            }
            else
            {
                InserareInVector(ref vector, ref n, e, k);

                Console.WriteLine("Vectorul dupa inserare:");
                AfisareVector(vector, n);
            }
        }

        static void InserareInVector(ref int[] vector, ref int n, int e, int k)
        {
            Array.Resize(ref vector, n + 1);

            for (int i = n; i > k; i--)
            {
                vector[i] = vector[i - 1];
            }

            vector[k] = e;
            n++;
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

