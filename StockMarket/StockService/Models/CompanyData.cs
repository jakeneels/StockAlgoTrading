using System;

namespace StockService.Models
{
    [Serializable]
    public class CompanyData
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public string Exchange { get; set; }
        public string Industry { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string CEO { get; set; }

        //refers to the common issue type of the stock.
        //ad – American Depository Receipt(ADR’s)
        //re – Real Estate Investment Trust(REIT’s)
        //ce – Closed end fund(Stock and Bond Fund)
        //si – Secondary Issue
        //lp – Limited Partnerships
        //cs – Common Stock
        //et – Exchange Traded Fund(ETF)
        //(blank) = Not Available, i.e., Warrant, Note, or(non-filing) Closed Ended Funds
        public string IssueType { get; set; }
    }
}