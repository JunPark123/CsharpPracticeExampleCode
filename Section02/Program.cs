using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<11; i++)
            {
                double meter = FeetToMeter(i);
                Console.WriteLine($"{i} ft = {meter:F4}");
            }
            Console.ReadLine();
        }

        static double FeetToMeter( int feet)
        {
            return feet * 0.3048;
        }
    }
}
