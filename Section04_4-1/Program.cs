using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04_4_1
{
    public class Program
    {
        static YearMonth find21Century(YearMonth[] years)
        {
            foreach (var year in years)
            {
                //처음발견하면 그 객체 반환
                if (year.Is21Century) return year;
            }

            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("####문제4.2 1번2번####");
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym.ToString());
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("####문제4.2 3번 4번####");
            var find21 = find21Century(ymCollection);
            var name = find21 == null ? "없습니다" : find21.ToString();

            Console.WriteLine($"3번,4번 : {name}");

            Console.WriteLine("----------------------");

            Console.WriteLine("####문제4.2 5번####");
            var ymCollection2 = new YearMonth[ymCollection.Length];

            for (int i = 0; i < ymCollection.Length; i++)
            {
                ymCollection2[i] =ymCollection[i].AddOneMonth();
            }

            foreach (var ym in ymCollection2)
            {
                Console.WriteLine(ym.ToString());
            }

            var array = ymCollection.Select(y => y.AddOneMonth()).ToArray();
            
            foreach(var ym in array)
            {
                Console.WriteLine(ym.ToString());
            }

            Console.ReadLine();
        }
    }
}
