using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_8
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

            RotireStangaVector(ref vector, n);

            Console.WriteLine("Vectorul dupa rotire:");
            AfisareVector(vector, n);
        }

        static void RotireStangaVector(ref int[] vector, int n)
        {
            if (n <= 1)
            {
                return;
            }

            int temp = vector[0];

            for (int i = 0; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            vector[n - 1] = temp;
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

