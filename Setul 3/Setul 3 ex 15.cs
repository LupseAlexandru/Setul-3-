using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_15
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
            EliminareDuplicate(vector, ref n);
            Console.WriteLine("Vectorul dupa eliminarea duplicatelor:");
            AfisareVector(vector, n);
        }
        static void EliminareDuplicate(int[] vector, ref int n)
        {
            if (n <= 1)
            {
                return;
            }

            int index = 1;

            for (int i = 1; i < n; i++)
            {
                bool esteDuplicate = false;
                for (int j = 0; j < index; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        esteDuplicate = true;
                        break;
                    }
                }
                if (!esteDuplicate)
                {
                    vector[index] = vector[i];
                    index++;
                }
            }
            n = index;
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

