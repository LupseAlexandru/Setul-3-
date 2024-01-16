using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_16
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

            int cmmd = CalculareCMMD(vector, n);

            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");
        }
        static int CalculareCMMD(int[] vector, int n)
        {
            int cmmd = vector[0];

            for (int i = 1; i < n; i++)
            {
                cmmd = CalculeazaCMMD(cmmd, vector[i]);

                if (cmmd == 1)
                {
                    break;
                }
            }

            return cmmd;
        }
        static int CalculeazaCMMD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}

