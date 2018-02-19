using StockService;
using StockService.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
         
        var hist = new HistMarketData();

           var stockSvc = new IEXStockService();
            // var stock = stockSvc.GetTopsMarketDataHist("aapl",20171015 ); //yyyymmdd

            //stockSvc.GetCompanyData("aapl");

            hist.ParseHistMarketDataTXT("aapl");
            //hist.ParseHistMarketDataTXT("goog");

           // hist.ParseHistMarketDataTXT("a");

            hist.PrintMarketData();
            // Console.WriteLine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            // Console.WriteLine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString());


            //Console.WriteLine($" aks price {stock.AskPrice} bid price  {stock.BidPrice}   bid size{stock.BidSize}  ask size {stock.AskSize}");
            Console.ReadKey();
        }
    }
}
