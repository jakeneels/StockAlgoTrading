using StockService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockService.Algos
{
    public class MeanReversion
    {
        public List<KeyStatsData> potentialStocks = new List<KeyStatsData>();

        public MeanReversion(List<KeyStatsData> list)
        {
            potentialStocks.AddRange(list);
        }

        public static string CalculateHighReversion(List<KeyStatsData> list)
        {
            string buySymbols = "" ;
            foreach (var stock in list)
            {
                 buySymbols = "";
                    string sellSymbols = "";

                double maxPercentChange = 0;
                double minPercentChange = 0;
                double percentChange = (100 / stock.Day200MovingAvg) - (100 / stock.Day50MovingAvg); // if value is positive this indicates the stock may increase to its average value so Buy, if negative sell or short
                if (percentChange > maxPercentChange)
                {
                    buySymbols += stock.Symbol;
                    maxPercentChange = percentChange;
                     Console.WriteLine($"Symbol {stock.Symbol}   maxpercentChange(buy) {maxPercentChange}    min(sell) {minPercentChange}    ");
                }
                if (percentChange < minPercentChange)
                {
                    sellSymbols += stock.Symbol;
                    minPercentChange = percentChange;
                    Console.WriteLine($"Symbol {stock.Symbol}   maxpercentChange(buy) {maxPercentChange}    min(sell) {minPercentChange}    ");
                }
            }
            return buySymbols;

        }
    }
}
