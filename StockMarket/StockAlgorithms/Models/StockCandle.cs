using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer.Models
{
    public class StockCandle
    {
        private Stock _stock;

        // Length of upper shadow moving up from body
        public double UShadow
        {
            get
            {
                return IsFilled ? (_stock.High - _stock.Open) : (_stock.High - _stock.Close);
            }
        }

        // Length of lower shadow moving down from body,, could make this value neg
        public double LShadow
        {
            get
            {
                return IsFilled ? (_stock.Open - _stock.Low) : (_stock.Close - _stock.Low);
            }
        } 

        public double Body
        {
            get
            {
                return IsFilled ? (_stock.Open - _stock.Close) : (_stock.Close - _stock.Open);
            }
        }

        // filled indicates more sold than bought that day
        public bool IsFilled
        {
            get
            {
                return (_stock.Open > _stock.Close) ? true : false;
            }
        }

        // Needs to be implemented
        public bool IsDoji()
        {
            return false;
        }

        //create stock candle, also method exists in Stock class stock.ToCandle()
        public StockCandle(Stock stock) 
        {
            _stock = stock;
        }

        public override string ToString()
        {
            return $"U Shadow: {Math.Round(UShadow,3)}    \nL Shadow: {Math.Round(LShadow,3)}     " +
                   $"Body: {Math.Round(Body,3)}    IsFilled: {IsFilled}";
        }
    }
}
