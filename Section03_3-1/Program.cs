using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_3_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48};

            var findnum = numbers.Exists(n => n %8 == 0 && n % 9 == 0);
            Console.WriteLine($"8과9로 나누어 떨어지는 수 찾기 => {findnum}");
            Console.ReadLine();

        }
    }
}
