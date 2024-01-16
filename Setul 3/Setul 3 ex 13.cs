using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_13
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

            InsertionSort(vector, n);

            Console.WriteLine("Vectorul sortat:");
            AfisareVector(vector, n);
        }

        static void InsertionSort(int[] vector, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int valoareCurenta = vector[i];
                int j = i - 1;
                while (j >= 0 && vector[j] > valoareCurenta)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = valoareCurenta;
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

