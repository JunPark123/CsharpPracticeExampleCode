using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02
{
   
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetTometerList(1, 10);
            }
            else
            {
                PrintMeterToFeetrList(1, 10);
            }


            Console.ReadLine();
        }

        static void PrintFeetTometerList(int start, int stop)
        {
            for (int i = start; i <= stop; i++)
            {
                double meter = FeetConverter.FeetToMeter(i);
                Console.WriteLine($"{i} ft = {meter:F4}");
            }
        }

        static void PrintMeterToFeetrList(int start, int stop)
        {
            for (int i = start; i <= stop; i++)
            {
                double meter = FeetConverter.MeterToFeet(i);
                Console.WriteLine($"{i} Meter = {meter:F4}");
            }
        }
    }
}



