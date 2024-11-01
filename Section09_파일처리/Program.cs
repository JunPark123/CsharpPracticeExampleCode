using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section09_파일처리
{
    class Program
    {
        static void Main(string[] args)
        {
            var di = new DirectoryInfo(@"C:\Users\Park_Jun\source");
            FileSystemInfo[] filesystems = di.GetFileSystemInfos();
            foreach (var item in filesystems)
            {
                if((item.Attributes & FileAttributes.Directory)== FileAttributes.Directory)
                {
                    Console.WriteLine($"{item.Name},// {item.CreationTime}");
                }
            }

            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var myDocumnetPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var programPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            var windowPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);

            Console.WriteLine($"{desktopPath}");
            Console.WriteLine($"{myDocumnetPath}");
            Console.WriteLine($"{programPath}");
            Console.WriteLine($"{windowPath}");
            Console.WriteLine($"{systemPath}");

            Console.ReadLine();

        }
    }
}
