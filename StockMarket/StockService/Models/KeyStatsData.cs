using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockService.Models
{
    public class KeyStatsData
    { // serialize
        public string CompanyName { get; set; }
        public decimal MarketCap { get; set; }
        public decimal beta { get; set; }
        public double Week52High { get; set; }
        public double Week52Low { get; set; }
        public double Week52Change { get; set; }
        public long ShortInterest { get; set; }
        public string ShortDate { get; set; }
        public decimal DividendRate { get; set; }
        public double  DividendYield { get; set; }
        public string exDividendDate { get; set; }  //date and time ex. "2017-05-11 00:00:00.0"
        public double LatestEPS { get; set; }
        public string LatestEPSDate { get; set; }
        public decimal SharesOutstanding { get; set; }
        public decimal Float { get; set; }
        public decimal ReturnOnEquity { get; set; }
        public double ConsensusEPS { get; set; }
        public int NumberOfEstimates { get; set; }
        public string Symbol { get; set; }
        public decimal EBITDA { get; set; }
        public decimal Revenue { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal Cash { get; set; }
        public decimal Debt { get; set; }
        public double TtmEPS { get; set; }
        public decimal RevenuePerShare { get; set; }
        public decimal RevenuePerEmployee { get; set; }
        public double PeRatioHigh { get; set; }
        public double PeRatioLow { get; set; }
        public double EPSSurpriseDollar { get; set; } //unknown return type, api docs say null
        public double EPSSurprisePercent { get; set; }
        public double ReturnOnAssets { get; set; }
        public double ReturnOnCapital { get; set; } //unknown return type, api docs say null
        public double ProfitMargin { get; set; }
        public double PriceToSales { get; set; }
        public double PriceToBook { get; set; }
        public double Day200MovingAvg { get; set; }
        public double Day50MovingAvg { get; set; }
        public double InstitutionPercent { get; set; }
        public double InsiderPercent { get; set; }
        public double ShortRatio { get; set; }
        public decimal Year5ChangePercent { get; set; }
        public decimal Year2ChangePercent { get; set; }
        public decimal Year1ChangePercent { get; set; }
        public decimal YtdChangePercent { get; set; }
        public decimal Month6ChangePercent { get; set; }
        public decimal Month3ChangePercent { get; set; }
        public decimal Month1ChangePercent { get; set; }
        public decimal Day5ChangePercent { get; set; }

    }
}
