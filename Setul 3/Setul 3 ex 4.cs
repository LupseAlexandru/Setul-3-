using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_3_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea vectorului: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] vector = new double[n];

            Console.WriteLine("Introduceti elementele vectorului:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elementul {i + 1}: ");
                vector[i] = Convert.ToDouble(Console.ReadLine());
            }

            DeterminaMinMaxSiFrecventa(vector, n, out double minValue, out double maxValue, out int frecventaMin, out int frecventaMax);

            Console.WriteLine($"Cea mai mica valoare: {minValue}, frecventa: {frecventaMin} ori.");
            Console.WriteLine($"Cea mai mare valoare: {maxValue}, frecventa: {frecventaMax} ori.");
        }

        static void DeterminaMinMaxSiFrecventa(double[] vector, int n, out double minValue, out double maxValue, out int frecventaMin, out int frecventaMax)
        {
            if (n == 0)
            {
                minValue = maxValue = 0;
                frecventaMin = frecventaMax = 0;
                return;
            }
            minValue = maxValue = vector[0];
            frecventaMin = frecventaMax = 1;
            for (int i = 1; i < n; i++)
            {
                if (vector[i] < minValue)
                {
                    minValue = vector[i];
                    frecventaMin = 1;
                }
                else if (vector[i] == minValue)
                {
                    frecventaMin++;
                }
                else if (vector[i] > maxValue)
                {
                    maxValue = vector[i];
                    frecventaMax = 1;
                }
                else if (vector[i] == maxValue)
                {
                    frecventaMax++;
                }
            }
        }
    }
}
