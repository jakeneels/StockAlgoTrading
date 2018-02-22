using StockAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAlgorithms.Models
{
    public class StockPattern
    {
        //www.humbletraders.com/candlestick-patterns/
        public enum eCandlePatterns
        {
            Unknown = 0,
            AbandonedBaby = 1,
            HaramiCross = 2
        }

        private List<StockCandle> _candles;

        public eCandlePatterns CandleStickPattern { get; set; } = eCandlePatterns.Unknown;

        public StockPattern(List<StockCandle> candles)
        {
            _candles = candles;

            DeterminePattern();
        }

        public bool IsBearishReversal
        {
            get
            {
                return (CandleStickPattern == eCandlePatterns.AbandonedBaby) ||
                       (CandleStickPattern == eCandlePatterns.HaramiCross);
            }
        }

        public bool IsBullishReversal
        {
            get
            {
                return (CandleStickPattern == eCandlePatterns.AbandonedBaby) ||
                       (CandleStickPattern == eCandlePatterns.HaramiCross);
            }
        }

        private void DeterminePattern()
        {
            if(IsAbandonedBaby())
            {
                CandleStickPattern = eCandlePatterns.AbandonedBaby;
            }
            else if (IsHaramiCross())
            {
                CandleStickPattern = eCandlePatterns.HaramiCross;
            }
        }
                
        private bool IsAbandonedBaby()
        {
            return false;
        }

        private bool IsHaramiCross()
        {
            return false;
        }
    }
}
