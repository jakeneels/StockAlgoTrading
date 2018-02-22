using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer.Models
{
    public class StockDecision
    {
        public enum eDecision
        {
            DoNothing = 0,
            Buy = 1,
            Sell = 2
        }

        public string Symbol { get; set; } = "";
        public eDecision Decision { get; set; } = eDecision.DoNothing;

        public StockDecision()
        {

        }

        public StockDecision(string symbol, eDecision decision)
        {
            Symbol = symbol;
            Decision = decision;
        }
    }
}
