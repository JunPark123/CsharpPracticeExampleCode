using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong" };

            var line = Console.ReadLine();
            var index = names.FindIndex(s => s == line);
            Console.WriteLine("입력된 값과 동일한 값 찾기");
            Console.WriteLine(index);


            
            Console.WriteLine($"소문자 찾기 {names.Count(n => n.Contains('o'))}");

            Console.WriteLine("o가 포함된 도시 찾고 배열로 저장하기");
            IEnumerable<string> cities = names.Where(s => s.Contains('o')).ToArray();
            foreach(var c in cities)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("마지막 문제.길어서 생략");
            IEnumerable<int> asdf = names.Where(s => s.FirstOrDefault()=='B').Select(s => s.Length).ToArray();
            foreach (var c in asdf)
            {
                Console.WriteLine(c);
            }


            Console.ReadLine();
        }
    }
}
