using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section02_CalCulatorSale
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            var sales = new SaleCounter(("sales.csv"));
            var amountPerStore = sales.GetPerStoreSales();
            foreach(var obj in amountPerStore)
            {
                Console.WriteLine($"{obj.Key}, {obj.Value}");
            }
            Console.ReadLine();
        }
    }
}
