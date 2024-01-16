using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar natural n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            AfiseazaNumerePrime(n);
        }

        static void AfiseazaNumerePrime(int n)
        {
            bool[] ciur = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                ciur[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (ciur[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        ciur[j] = false;
                    }
                }
            }
            Console.WriteLine($"Numere prime mai mici sau egale cu {n}:");
            for (int i = 2; i <= n; i++)
            {
                if (ciur[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

