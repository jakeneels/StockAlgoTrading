using System;
using System.Collections.Generic;
using DatabaseService.Models;

namespace DatabaseService
{
    interface IDatabaseService
    {
        List<Stock> GetStockData(string symbol, int numDaysData);

        
    }
}