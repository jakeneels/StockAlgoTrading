﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseService.Models;

namespace StockService.Models
{

    //Date,Open,High,Low,Close,Volume,OpenInt

    public class HistMarketData
    {
        public string SymbolQuery { get; set; }
        public DateTime DateRange { get; set; }
        public List<Stock> History = new List<Stock>();

        public void ParseHistMarketDataTXT(string symbol)  // probably complete
        {
            try
            {
                var hist = new Stock()
                {
                    Symbol = "appl"
                };

                //Directory.GetParent(Environment.CurrentDirectory);
                //DirectoryInfo rootDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory)));
                long lineCount = -1;

                string[] allSymbolData = File.ReadAllLines($"Stocks/{symbol}.us.txt"); // make this independent. put db in debug to test
                foreach (string line in allSymbolData)
                {
                    Stock thisDayData = new Stock();

                    lineCount++;
                    string[] lineStr = line.Split(',');
                    if (lineCount % 1000 == 0)
                    {
                        Console.WriteLine($"parsing line {lineCount}");
                    }
                    if (lineCount > 0)
                    {
                        try
                        {
                            thisDayData.Symbol = symbol;
                            thisDayData.Date = lineStr[0];
                            thisDayData.Open = double.Parse(lineStr[1]);
                            thisDayData.High = double.Parse(lineStr[2]);  //double.TryParse(lineStr[2], out Open);
                            thisDayData.Low = double.Parse(lineStr[3]);
                            thisDayData.Close = double.Parse(lineStr[4]);
                            thisDayData.Volume = long.Parse(lineStr[5]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"line {lineCount} error Reads {ex}");
                        }

                        History.Add(thisDayData);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void PrintMarketData() // working, not complete
        {
            Console.WriteLine($"Writing {SymbolQuery}");
            //Console.WriteLine("Date".PadRight(10) + "High".PadRight(10));
            foreach (var day in History)
            {
                Console.WriteLine(day.ToString());
                // + $"High: {day.High.ToString().PadRight(10)}");
            }
        }
    }
}
