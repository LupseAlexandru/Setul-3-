using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_12
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

            SelectionSort(vector, n);

            Console.WriteLine("Vectorul sortat:");
            AfisareVector(vector, n);
        }

        static void SelectionSort(int[] vector, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int indexMinim = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[indexMinim])
                    {
                        indexMinim = j;
                    }
                }
                int temp = vector[i];
                vector[i] = vector[indexMinim];
                vector[indexMinim] = temp;
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
    

