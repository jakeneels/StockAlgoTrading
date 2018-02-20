using System;

namespace DatabaseService.Models
{
    [Serializable]
    public class Stock
    {

        public string Symbol { get; set; }
        public string Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public int OpenInterest { get; set; }           // Open interest is the total number of open or outstanding (not closed or delivered) options and/or futures contracts that exist on a given day, delivered on a particular day
        public long Volume { get; set; }

        public override string ToString()
        {
            return $"Symbol: {Symbol.PadRight(20)}Date: {Date.PadRight(20)} High: {High.ToString().PadRight(10)} Low: {Low.ToString().PadRight(10)} Volume: {Volume}";
        }
    }
}
