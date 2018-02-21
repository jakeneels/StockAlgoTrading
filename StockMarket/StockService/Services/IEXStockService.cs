using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using StockService.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                    Console.WriteLine(jsonStr);
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
                    Console.WriteLine(jsonStr);

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
                    Console.WriteLine(jsonStr);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return stock;
        }


        public KeyStatsData GetKeyStats(String symbol) // Needs conversion for KeyStatsDAta
        {
            var symbols = new List<String>();
            symbols.Add(symbol);
            var stocks = GetKeyStats(symbols);
            return stocks.ElementAt(0);
        }

        public List<KeyStatsData> GetKeyStats(List<String> symbols)  // Needs conversion for KeyStatsDAta
        {
            List<KeyStatsData> stocks = null;
            string uri = "";

            try
            {
                //https://api.iextrading.com/1.0/stock/aapl/stats
                foreach (var symbol in symbols)
                {
                    uri = $"https://api.iextrading.com/1.0/stock/{symbol}/stats";
                    var req = WebRequest.Create(uri);
                    var stream = req.GetResponse().GetResponseStream();
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        var jsonStr = sr.ReadToEnd();
                        var jObj = JObject.Parse(jsonStr);
                        // clip of json {"companyName":"Apple Inc.","marketcap":874912061590,...
                        //"day200MovingAvg":159.09383,"day50MovingAvg":170.19109,"institutionPercent":62.2,"insiderPercent":null,"shortRatio":1.339517,"year5ChangePercent":1.6239941076928697,"year2ChangePercent":0.7953977509371095,"year1ChangePercent":0.2613752743233359,"ytdChangePercent":0.0009868802972252172,"month6ChangePercent":0.09681317982316645,"month3ChangePercent":0.01441346040710682,"month1ChangePercent":-0.033789084388658526,
                        string day200avg = jObj.SelectToken("day200MovingAvg").ToString();
                        Console.WriteLine(day200avg);
                        //stocks = JsonConvert.DeserializeObject<List<KeyStatsData>>(jsonStr);
                        //Console.WriteLine(jsonStr);
                    }
                   // stocks.Add()
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return stocks;
        }







       
        
        
        
        
        //Depricated??

        //public List<TopsMarketData> GetTopsMarketDataHist()
        //{
        //    List<TopsMarketData> stocks = null;

        //    try
        //    {
        //        var req = WebRequest.Create("https://api.iextrading.com/1.0/hist");
        //        var stream = req.GetResponse().GetResponseStream();
        //        using (StreamReader sr = new StreamReader(stream))
        //        {
        //            var jsonStr = sr.ReadToEnd();
        //            stocks = JsonConvert.DeserializeObject<List<TopsMarketData>>(jsonStr);
        //            Console.WriteLine(jsonStr);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    return stocks;
        //}

        //public TopsMarketData GetTopsMarketDataHist(String symbol, int date)
        //{
        //    var symbols = new List<String>();
        //    symbols.Add(symbol);
        //    var stocks = GetTopsMarketDataHist(symbols, date);
        //    return stocks.ElementAt(0);
        //}

        //public List<TopsMarketData> GetTopsMarketDataHist(List<String> symbols , int date)
        //{
        //    List<TopsMarketData> stocks = null;

        //    try
        //    {
        //        String uri = "https://api.iextrading.com/1.0/hist?date={date}symbols=";
        //        bool isFirstTime = true;
        //        foreach (var symbol in symbols)
        //        {
        //            if (!isFirstTime)
        //            {
        //                uri += ",";
        //            }
        //            else
        //            {
        //                isFirstTime = false;
        //            }
        //            uri += symbol;
        //        }
        //        var req = WebRequest.Create(uri);
        //        var stream = req.GetResponse().GetResponseStream();
        //        using (StreamReader sr = new StreamReader(stream))
        //        {
        //            var jsonStr = sr.ReadToEnd();
        //            stocks = JsonConvert.DeserializeObject<List<TopsMarketData>>(jsonStr);
        //            Console.WriteLine(jsonStr);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    return stocks;
        //}
    }
}
