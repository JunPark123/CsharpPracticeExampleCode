using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02
{
    public static class FeetConverter
    {
        private static readonly double ratio = 0.3048;
        public static double FeetToMeter(double feet)
        {
            return feet * ratio;
        }

        public static double MeterToFeet(double meter)
        {
            return meter / ratio;
        }
    }
}
