using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseService.Models
{
    public class StockCandle
    {
        public double UShadow { get; } // Length of upper shadow moving up from body
        public double LShadow { get; } // Length of lower shadow moving down from body,, could make this value neg
        public double Body { get; }
        public bool IsFilled { get; }  // filled indicates more sold than bought that day
 
        public StockCandle(Stock stock) //create stock candle, also method exists in Stock class stock.ToCandle()
        {
            if (stock.Open > stock.Close)
                IsFilled = true;
            else
                IsFilled = false;

            Body = IsFilled ? stock.Open - stock.Close : stock.Close - stock.Open;
            LShadow = IsFilled ? stock.Open - stock.Low : stock.Close - stock.Low;
            UShadow = IsFilled ? stock.High - stock.Open : stock.High - stock.Close;
        }

        public override string ToString()
        {
            return $"U Shadow: {Math.Round(UShadow,3)}    \nL Shadow: {Math.Round(LShadow,3)}     " +
                   $"Body: {Math.Round(Body,3)}    IsFilled: {IsFilled}";
        }
    }
}
