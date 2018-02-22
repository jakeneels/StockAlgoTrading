using StockService;
using StockService.Models;
using DatabaseService.Services; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseService.Models;
using StockService.Algos;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
         
           var stockSvc = new IEXStockService();
            // var stock = stockSvc.GetTopsMarketDataHist("aapl",20171015 ); //yyyymmdd
            StockHistoryService stockHist = new StockHistoryService();
           
            stockHist.ParseHistoryData("a,st,tntr, ,tol,ths,aapl,test"); ///,ssy,st,spxe,tntr,toca,tol,ths,tsco
            StockCandle candle = new StockCandle(stockHist.History[1]);
            Console.WriteLine(stockHist.History[8000].ToString());
            Console.WriteLine(stockHist.History[8000].toCandle().ToString());

            Console.WriteLine(stockSvc.GetKeyStats("uec").ShortReport());
            Console.WriteLine(stockSvc.GetKeyStats("glbs").ShortReport());

            MeanReversion.CalculateHighReversion(stockSvc.GetKeyStats(new List<String> { "aapl", "a", "glbs", "tops", "uec" }));

            //List<Stock> days30 = stockHist.GetStockData(stockHist.History, "aapl", 30);
          
           // candle = new StockCandle(stockHist.History[8010]);
            //Console.WriteLine(stockHist.History[8010].ToString());
            ///Console.WriteLine(candle.ToString());
            //Stock.ListToString(days30);

            //Console.WriteLine(candle.UShadow);
            //stockHist.PrintMarketData();
            //stockSvc.GetCompanyData("aapl");
            //Console.WriteLine($" aks price {stock.AskPrice} bid price  {stock.BidPrice}   bid size{stock.BidSize}  ask size {stock.AskSize}");
            Console.ReadKey();
        }
    }
}
