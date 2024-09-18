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

            Console.WriteLine($"ForEach로 요소들 2로 나누기");
            numbers.ForEach(n=>Console.WriteLine(n/2));

            Console.WriteLine($"LinQ로 50이상인 요소 열거하기");
            IEnumerable<int> query= numbers.Where(n => n >= 50);
            foreach(var v in query)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine($"LinQ로 4번 풀기.길어서 생략");
            List<int> numbs = numbers.Select(n => n * 2).ToList();
            foreach (var v in numbs)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();

        }
    }
}
