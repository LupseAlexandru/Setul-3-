using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_9
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

            Console.Write("Introduceti numarul de pozitii pentru rotirea spre stanga: ");
            int k = Convert.ToInt32(Console.ReadLine());

            RotireStangaKVector(ref vector, n, k);

            Console.WriteLine($"Vectorul dupa rotirea spre stanga cu {k} pozitii:");
            AfisareVector(vector, n);
        }

        static void RotireStangaKVector(ref int[] vector, int n, int k)
        {
            k %= n; 

            if (k == 0)
            {
                return;
            }

            int[] temp = new int[k];
            for (int i = 0; i < k; i++)
            {
                temp[i] = vector[i];
            }
            for (int i = 0; i < n - k; i++)
            {
                vector[i] = vector[i + k];
            }
            for (int i = n - k, j = 0; i < n; i++, j++)
            {
                vector[i] = temp[j];
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
