using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class Program
    {
        static void Summary()
        {
            /*
            * ##문자열 관련 내용 정리
            1. Compare는 대/소문자 구분 안하고 비교
            2. 문자열이 null인지 빈문자열인지 조사는 isNullOrEmpty 메서드를 사용한다
            3. null이 아닌 것이 보장되면 string.Empty 또는 ""를 사용해도 됨.
            4. Startswith을 사용하면 시작되는지 조사할수 있다. EndWith은 끝나는지 조사
            5. Any메서드를 사용하면 어떤 조건을 만족하는 문자가 포함돼 있는지 조사할 수 있다.
            6. 문자열 공백은 Trim 메서드를 사용한다. (문자열 앞뒤에 있는)
            7. Join메서드는 문자열 배열에 구분기호를 연결하여 문자열로 만들수 있다
            8. foreach문을 사용해서 문자열을 연결할 경우에 stringBuilder를 사용한다 그외에는 +연산자 사용
            */
            var target = "c# prgramming";
            var target2 = "C# Programming";
            var isExists = target.Any(c => char.IsLower(c));
            Console.WriteLine(isExists);
            isExists = target2.Any(c => char.IsLower(c));
            Console.WriteLine(isExists);

            var text = "The quick brown fox jumps over the lazy dog.";
            var words = text.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var worda = text.Split(new[] { ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in worda)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }

        static void Exercise1()
        {
            Console.WriteLine("연습문제1입니다 -- 문자열비교");
            var sA = Console.ReadLine();
            var sB = Console.ReadLine();
            if (string.Compare(sA, sB, ignoreCase: true) == 0)
            {
                Console.WriteLine("같다");
            }
            else
            {
                Console.WriteLine("다르다");
            }

            Console.WriteLine("연습문제1입니다 -- 엔터누르삼");
            Console.ReadLine();
        }

        static void Exercise2()
        {
            Console.WriteLine("연습문제2입니다 -- 숫자입력하셈");
            var sA = Console.ReadLine();
            int num;
            if (int.TryParse(sA, out num) == true)
            {
                Console.WriteLine("변환완료");
                Console.WriteLine("{0:#,#}", num);
            }
            else
            {
                Console.WriteLine("변환실패");
            }

            Console.ReadLine();
        }

        static void Exercise3_1()
        {
            Console.WriteLine("연습문제3-1입니다 -- 숫자입력하셈");
            var str = "Jackdaws love my big sphinx of quartz";
            var space = str.Count(n => n == ' ');
            Console.WriteLine(space);
            Console.ReadLine();
        }

        static void Exercise3_2()
        {
            Console.WriteLine("연습문제3-2입니다 -- 숫자입력하셈");
            var str = "Jackdaws love my big sphinx of quartz";
            var target = str.Replace("big", "small");
            Console.WriteLine(target);
            Console.ReadLine();
        }

        static void Exercise3_3()
        {
            Console.WriteLine("연습문제3-3입니다 -- 숫자입력하셈");
            var str = "Jackdaws love my big sphinx of quartz";
            var index = str.Length;
            Console.WriteLine(index);
            Console.ReadLine();
        }

        static void Exercise3_4()
        {
            Console.WriteLine("연습문제3-4입니다 -- 숫자입력하셈");
            var str = "Jackdaws love my big sphinx of quartz";
            var words = str.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var a = words.Where(x => x.Length < 4).ToArray();
            foreach (var x in a)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        static void Exercise3_5()
        {
            Console.WriteLine("연습문제3-5입니다 -- 숫자입력하셈");
            var str = "Jackdaws love my big sphinx of quartz";
            var words = str.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sB = new StringBuilder(words[0]);

            foreach (var x in words.Skip(1))
            {
                sB.Append(' ');
                sB.Append(x);
            }
            Console.WriteLine(sB.ToString());
            Console.ReadLine();
        }

        static void Exercise4()
        {
            Console.WriteLine("연습문제4입니다 -- 숫자입력하셈");

            var str = "Novelist=김만중;BestWork=구운몽;Born=1687;";
            var word = str.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);


            string names;
            foreach (var x in word)
            {
               var clone = x.SkipWhile(c => c != '=')
                    .Skip(1)
                    .Where(c => !char.IsWhiteSpace(c)).ToArray();
                names = new string(clone);
            }

            string[] abcde;
            foreach(var x in str.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                var array = x.Split('=');
                Console.WriteLine($"{forstring(array[0])}{array[1]}");

            }

            Console.ReadLine();
        }

        static string forstring(string str)
        {
            string replaceStr = "";
            switch (str)
            {
                case "Novelist":
                    replaceStr = "작가  : ";
                    break;
                case "BestWork":
                    replaceStr = "대표작: ";
                    break;
                case "Born":
                    replaceStr = "출판연도: ";
                    break;
            }
            return replaceStr;
        }

        static void Main(string[] args)
        {
            Exercise4();
            Exercise3_1();
            Exercise3_2();
            Exercise3_3();
            Exercise3_4();
            Exercise3_5();
        }


    }
}
