using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using StockService.Models;
using Newtonsoft.Json;

namespace StockService
{
    public class IEXStockService : IStockService
    {
        static HttpClient client = new HttpClient();

        public List<TopsMarketData> GetTopsMarketData()
        {
            List<TopsMarketData> stocks = null;

            try
            {
                var req = WebRequest.Create("https://api.iextrading.com/1.0/tops");
                var stream = req.GetResponse().GetResponseStream();
                using (StreamReader sr = new StreamReader(stream))
                {
                    var jsonStr = sr.ReadToEnd();
                    stocks = JsonConvert.DeserializeObject<List<TopsMarketData>>(jsonStr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return stocks;
        }

        public TopsMarketData GetTopsMarketData(String symbol)
        {
            var symbols = new List<String>();
            symbols.Add(symbol);
            var stocks = GetTopsMarketData(symbols);
            return stocks.ElementAt(0);
        }

        public List<TopsMarketData> GetTopsMarketData(List<String> symbols)
        {
            List<TopsMarketData> stocks = null;

            try
            {
                String uri = "https://api.iextrading.com/1.0/tops?symbols=";
                bool isFirstTime = true;
                foreach(var symbol in symbols)
                {
                    if (!isFirstTime)
                    {
                        uri += ",";
                    }
                    else
                    {
                        isFirstTime = false;
                    }
                    uri += symbol;
                }
                var req = WebRequest.Create(uri);
                var stream = req.GetResponse().GetResponseStream();
                using (StreamReader sr = new StreamReader(stream))
                {
                    var jsonStr = sr.ReadToEnd();
                    stocks = JsonConvert.DeserializeObject<List<TopsMarketData>>(jsonStr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return stocks;
        }

        public CompanyData GetCompanyData(String symbol)
        {
            CompanyData stock = null;

            try
            {
                String uri = "https://api.iextrading.com/1.0/stock/" + symbol + "/company";
                var req = WebRequest.Create(uri);
                var stream = req.GetResponse().GetResponseStream();
                using (StreamReader sr = new StreamReader(stream))
                {
                    var jsonStr = sr.ReadToEnd();
                    stock = JsonConvert.DeserializeObject<CompanyData>(jsonStr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return stock;
        }
    }
}
