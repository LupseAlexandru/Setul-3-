using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din vector: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] vector = new int[n];
            Console.WriteLine("Introduceti elementele vectorului(foloseste tasta SPACE):");
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                vector[i] = Convert.ToInt32(input[i]);
            }
            int suma = Suma(vector);
            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
        }
        static int Suma(int[] vector)
        {
            int suma = 0;
            foreach (int element in vector)
            {
                suma += element;
            }
            return suma;
        }
    }
}

