using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAlgorithms.Models
{
    [Serializable]
    public class Ticker
    {
        public int Id { get; set; }
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string exchange { get; set; }
        public string industry { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        public string ceo { get; set; }

        public override string ToString()
        {
            return $"\nSymbol: {symbol.PadRight(10)}Company Name: {companyName.PadRight(20)}\n" +
                    $"Exchange: {exchange.ToString().PadRight(10)}\n " +
                    $"Industry: {industry.ToString().PadRight(10)} Website: {website.ToString().PadRight(10)}"+
                    $"Description: {description. PadRight(10)} CEO: {ceo}}";
        }
    }


}
