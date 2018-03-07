using System;
using System.Collections.Generic;

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
<<<<<<< HEAD
        public int OpenInterest { get; set; } // Open interest is the total number of open or outstanding (not closed or delivered) options and/or futures contracts that exist on a given day, delivered on a particular day
=======
>>>>>>> efd188f06b7237cdf90f9256a1b73c2de9d671e7
        public long Volume { get; set; }

        public override string ToString()
        {
            return  $"\nSymbol: {Symbol.PadRight(10)}Date: {Date.PadRight(20)}\n" +
                    $"High: {High.ToString().PadRight(10)}  Open: {Open.ToString().PadRight(10)}\n " +
                    $"Low: {Low.ToString().PadRight(10)} Close: {Close.ToString().PadRight(10)}";
        }

<<<<<<< HEAD
        public StockCandle toCandle() => new StockCandle(this);
=======
        public StockCandle ToCandle()
        {
            return new StockCandle(this);
        }
>>>>>>> efd188f06b7237cdf90f9256a1b73c2de9d671e7
       
    }
}
