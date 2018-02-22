﻿using System;
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
        public long Volume { get; set; }

        public static void ListToString(List<Stock> list)
        {
            foreach (var stock in list)
            {
                Console.WriteLine(stock.ToString());
            }
        }

        public override string ToString()
        {
            return $"\nSymbol: {Symbol.PadRight(10)}Date: {Date.PadRight(20)}\n" +
                $"High: {High.ToString().PadRight(10)}  Open: {Open.ToString().PadRight(10)}\n " +
                $"Low: {Low.ToString().PadRight(10)} Close: {Close.ToString().PadRight(10)}";
        }

        public StockCandle ToCandle()
        {
            return new StockCandle(this);
        }
       
    }
}
