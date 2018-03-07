using System;
using System.Collections.Generic;
using StockAnalyzer.Models;

namespace StockAnalyzer
{
    interface IDatabaseService
    {
        List<Stock> GetStockData(string symbol, int numDaysBack);
        List<Stock> GetStockData(List<Stock> list, string symbol, int numDaysBack);

    }
}