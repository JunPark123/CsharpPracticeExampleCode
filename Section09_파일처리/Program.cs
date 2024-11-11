using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section09_파일처리
{
    public class Program
    {
        public static void WriteText()
        {
            if (!IsUserAdministrator())
            {
                Console.WriteLine("이 프로그램을 실행하려면 관리자 권한이 필요합니다.");
                return;
            }
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "흑백요리사.txt");
            
            //기본생성자 : 파일이 존재하지 않으면 새로 생성 존재하면 덮어쓰기
            //append true : 끝 행에 추가 , false : 덮어쓰기
            using (var writer = new StreamWriter(filePath, append: true))
                {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("저는 비빔인간입니다");
                writer.WriteLine("저의 이름은 이균입니다");
            }
        
                }

        static bool IsUserAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }


        static void Main(string[] args)
        {
            if (!IsUserAdministrator())
            {
                // 관리자 권한으로 재시작
                var processInfo = new ProcessStartInfo
                {
                    FileName = Process.GetCurrentProcess().MainModule.FileName,
                    UseShellExecute = true,
                    Verb = "runas" // 관리자 권한으로 실행
                };

                try
                {
                    Process.Start(processInfo);
                }
                catch
                {
                    Console.WriteLine("관리자 권한 요청이 취소되었습니다.");
                }
                return; // 현재 프로세스 종료
            }

            WriteText();
            Console.ReadLine();

        }
    }
}
