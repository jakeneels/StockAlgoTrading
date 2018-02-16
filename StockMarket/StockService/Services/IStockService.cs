using StockService.Models;
using System;
using System.Collections.Generic;

namespace StockService
{
    interface IStockService
    {
        List<TopsMarketData> GetTopsMarketData(List<String> symbols);
        TopsMarketData GetTopsMarketData(String symbol);
        List<TopsMarketData> GetTopsMarketData();
        CompanyData GetCompanyData(String symbol);
    }
}
