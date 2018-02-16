using System;

namespace StockService.Models
{
    [Serializable]
    public class TopsMarketData
    {
        public string Symbol { get; set; }
        public double MarketPercent { get; set; }
        public int BidSize { get; set; }
        public double BidPrice { get; set; }
        public int AskSize { get; set; }
        public double AskPrice { get; set; }
        public int Volume { get; set; }
        public double LastSalePrice { get; set; }
        public int LastSaleSize { get; set; }
        public long LastSaleTime { get; set; }
        public long LastUpdated { get; set; }
        public string Sector { get; set; }
        public string SecurityType { get; set; }

        public String GetLastSaleTime()
        {
            var time = new DateTime(LastSaleTime);
            return time.ToShortTimeString();
        }
        public String GetLastUpdatedTime()
        {
            var time = new DateTime(LastUpdated);
            return time.ToShortTimeString();
        }
    }
}