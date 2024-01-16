using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din vector: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului (foloseste tasta SPACE):");
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(input[i]);
            }

            Console.Write("Introduceti valoarea k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            int pozitie = -1;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] == k)
                {
                    pozitie = i;
                    break;
                }
            }

            Console.WriteLine($"Prima pozitie la care apare {k} in vector este: {pozitie}");
        }
    }
}

