using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockService.Models
{
    public class HistDayData
    {

        public string Symbol        { get; set; }
        public string Date          { get; set; }  // parse to DT class in set
        public double Open          { get; set; }
        public double High          { get; set; }
        public double Low           { get; set; }
        public double Close         { get; set; }
        public long   Volume        { get; set; }
        public int    OpenInterest  { get; set; }           // Open interest is the total number of open or outstanding (not closed or delivered) options and/or futures contracts that exist on a given day, delivered on a particular day

        public HistDayData(string symbol, string date, double open, 
                           double high, double low, double close,
                           long volume, int openInterest)
        {
            Symbol = symbol;
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
            OpenInterest = openInterest;
        }
        public HistDayData()
        {

        }
    }
}
