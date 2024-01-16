using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti gradul polinomului (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] coeficienti = new double[n + 1];

            Console.WriteLine("Introduceti coeficientii polinomului de la a0 la an:");

            for (int i = 0; i <= n; i++)
            {
                Console.Write($"a{i}: ");
                coeficienti[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Introduceti valoarea lui x pentru evaluare: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double rezultat = EvalueazaPolinom(coeficienti, x);

            Console.WriteLine($"Valoarea polinomului in punctul {x} este: {rezultat}");
        }
        static double EvalueazaPolinom(double[] coeficienti, double x)
        {
            double rezultat = 0;

            for (int i = 0; i < coeficienti.Length; i++)
            {
                rezultat += coeficienti[i] * Math.Pow(x, i);
            }
            return rezultat;
        }
    }
}

