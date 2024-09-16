using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Section02_CalCulatorSale
{
    public class SaleCounter
    {
        private IEnumerable<Sale> _sales;

        public SaleCounter(string filepath)
        {
            _sales = ReadSales(filepath);

        }

        public IDictionary<string, int> GetPerStoreSales()
        {
           var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }

        private static List<Sale> ReadSales(string filepath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filepath);//파일 데이터가 별로 없을떄 ReadLine 사용해도 괜츈함
            foreach (string line in lines)
            {
                string[] item = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = item[0],
                    ProductCategory = item[1],
                    Amount = int.Parse(item[2])

                };

                sales.Add(sale);
            }
            return sales;
        }
    }
}
