using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockAnalyzer.Models;
using StockService.Models;


namespace StockAnalyzer.Services
{
    public class StockHistoryService : IDatabaseService
    {
        public List<Stock> GetStockData(List<Stock> list, string symbol, int numDaysBack)
        {
            List<Stock> stockData = new List<Stock>(); // to model a collection range or to not
            
            for (int i = History.Count-1; i > numDaysBack; i--)
            {
                if(list[i].Symbol == symbol)
                stockData.Add(History[i]);
            }
            return stockData;
        }

        public string SymbolQuery { get; set; }
        public DateTime DateRange { get; set; }
        public List<Stock> History { get => history; private set => history = value; }
        private List<Stock> history = new List<Stock>();

        public void ParseHistoryData(string symbols)
        {
            if (symbols.Contains(','))
                ParseSymbols(symbols);
            else
                ParseSymbol(symbols);
        }
       // private void ParseList()

        private void ParseSymbol(string symbol) // make a seperate method to import from file and make a override to take a list
        {
            try
            {
                long lineCount = -1;
                int errorCount = 0;
                string[] allSymbolData = File.ReadAllLines(
                    $"..\\..\\..\\DatabaseService/HistData/Stocks/{symbol}.us.txt");

                Console.Write($"parsing \"{symbol}\"");

                foreach (string line in allSymbolData)
                {
                    Stock thisDayData = new Stock();

                    lineCount++;
                    string[] lineStr = line.Split(',');

                    if (lineCount % 1000 == 0)
                        Console.Write(".");

                    if (lineCount > 0)
                    {
                        try
                        {
                            thisDayData.Symbol = symbol;
                            thisDayData.Date = lineStr[0];
                            thisDayData.Open = double.Parse(lineStr[1]);
                            thisDayData.High = double.Parse(lineStr[2]);
                            thisDayData.Low = double.Parse(lineStr[3]);
                            thisDayData.Close = double.Parse(lineStr[4]);
                            thisDayData.Volume = long.Parse(lineStr[5]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"line {lineCount} error Reads {ex}");
                            errorCount++;
                        }

                        History.Add(thisDayData);
                    }
                }
                Console.WriteLine($"parsed {lineCount} lines successfully with {errorCount} errors");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ParseSymbols(string symbols)  // probably complete
        {
            List<string> symbolList = new List<string>(); ;
            string[] symbolsArr = symbols.Split(',');
            symbolList = symbolsArr.ToList();

            foreach (var symbol in symbolList)
            {
                ParseHistoryData(symbol);
            }
        }

        public void PrintHistoryData()
        {
            Console.WriteLine($"Writing {SymbolQuery}");
            foreach (var day in History)
            {
                Console.WriteLine(day.ToString());
            }
        }

        public List<Stock> GetStockData(string symbol, int numDaysBack)
        {
            List<Stock> stockData = new List<Stock>(); // to model a collection range or to not



            for (int i = History.Count - 1; i > numDaysBack; i--)
            {
                //if (list[i].Symbol == symbol)
                   // stockData.Add(History[i]);
            }
            return stockData;
        }
    }
}
