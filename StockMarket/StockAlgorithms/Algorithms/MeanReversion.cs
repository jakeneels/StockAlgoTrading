using StockAnalyzer.Models;
using StockService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer.Algorithms
{
    public class MeanReversion
    {
        private List<KeyStatsData> _potentialStocks;

        public MeanReversion(List<KeyStatsData> list)
        {
            _potentialStocks = list;
        }

        public static List<StockDecision> CalculateHighReversion(List<KeyStatsData> list)
        {
            List<StockDecision> decisionList = new List<StockDecision>();
            foreach (var stock in list)
            {
                double maxPercentChange = 0;
                double minPercentChange = 0;
                double percentChange = (100 / stock.Day200MovingAvg) - (100 / stock.Day50MovingAvg);
                
                // if value is positive this indicates the stock may increase to its average value so Buy, 
                // if negative sell or short
                if (percentChange > maxPercentChange)
                {
                    decisionList.Add(new StockDecision(stock.Symbol, StockDecision.eDecision.Buy));
                    maxPercentChange = percentChange;
                }
                else if (percentChange < minPercentChange)
                {
                    decisionList.Add(new StockDecision(stock.Symbol, StockDecision.eDecision.Sell));
                    minPercentChange = percentChange;
                }
                else
                {
                    decisionList.Add(new StockDecision(stock.Symbol, StockDecision.eDecision.DoNothing));
                }
            }
            return decisionList;
        }
    }
}
