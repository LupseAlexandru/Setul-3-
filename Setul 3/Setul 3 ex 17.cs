using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul in baza 10: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti baza (1 < b < 17): ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b < 2 || b > 16)
            {
                Console.WriteLine("Baza introdusa nu este valida.");
                return;
            }
            string rezultat = ConversieBaza10InB(n, b);
            Console.WriteLine($"Numarul {n} in baza {b}: {rezultat}");
        }

        static string ConversieBaza10InB(int n, int b)
        {
            if (n == 0)
            {
                return "0";
            }
            string rezultat = "";

            while (n > 0)
            {
                int rest = n % b;
                char cifra = (char)(rest < 10 ? rest + '0' : rest - 10 + 'A');

                rezultat = cifra + rezultat;

                n /= b;
            }
            return rezultat;
        }
    }
}
