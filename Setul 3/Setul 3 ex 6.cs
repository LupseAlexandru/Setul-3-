using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_6
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

            Console.Write("Introduceti pozitia elementului de sters: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k < 0 || k >= n)
            {
                Console.WriteLine("Pozitia introdusa este invalida.");
            }
            else
            {
                StergeElementDinVector(ref vector, ref n, k);

                Console.WriteLine("Vectorul dupa stergere:");
                AfisareVector(vector, n);
            }
        }

        static void StergeElementDinVector(ref int[] vector, ref int n, int k)
        {
            for (int i = k; i < n - 1; i++)
            {
                vector[i] = vector[i + 1];
            }

            Array.Resize(ref vector, n - 1);
            n--;
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

