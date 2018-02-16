using StockService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockSvc = new IEXStockService();
            var stock = stockSvc.GetCompanyData("aapl");
            Console.WriteLine(stock.CompanyName);
            Console.ReadKey();
        }


    }
}
