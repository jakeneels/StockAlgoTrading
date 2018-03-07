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
            HaramiCross = 2,
            DragonFly = 3,
            MorningStar = 4,
            EveningStar = 5,
            Gravestone = 6,
            Hammer = 7,
            InvertedHammer = 8,
            HangingMan = 9,
            SpinningTop = 10,
            ShootingStar = 11,
            UpsideGapWithTwoCrows = 12,
            DarkCloudCover = 13,
            EngulfingPatterns = 14,
            PiercingLine = 15,
            CandlestickSandwich = 16,
            ThreeGreenSoldiers = 17
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
                return (CandleStickPattern == eCandlePatterns.Gravestone) ||
                       (CandleStickPattern == eCandlePatterns.EveningStar) ||
                       (CandleStickPattern == eCandlePatterns.HaramiCross);
            }
        }

        public bool IsBullishReversal
        {
            get
            {
                return (CandleStickPattern == eCandlePatterns.HaramiCross);
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
            else if (IsDragonFly())
            {
                CandleStickPattern = eCandlePatterns.DragonFly;
            }
            else if (IsMorningStar())
            {
                CandleStickPattern = eCandlePatterns.MorningStar;
            }
            else if (IsEveningStar())
            {
                CandleStickPattern = eCandlePatterns.EveningStar;
            }
            else if (IsGravestone())
            {
                CandleStickPattern = eCandlePatterns.Gravestone;
            }
            else if (IsHammer())
            {
                CandleStickPattern = eCandlePatterns.Hammer;
            }
            else if (IsInvertedHammer())
            {
                CandleStickPattern = eCandlePatterns.InvertedHammer;
            }
            else if (IsHangingMan())
            {
                CandleStickPattern = eCandlePatterns.HangingMan;
            }
            else if (IsSpinningTop())
            {
                CandleStickPattern = eCandlePatterns.SpinningTop;
            }
            else if (IsShootingStar())
            {
                CandleStickPattern = eCandlePatterns.ShootingStar;
            }
            else if (IsUpsideGapWithTwoCrows())
            {
                CandleStickPattern = eCandlePatterns.UpsideGapWithTwoCrows;
            }
            else if (IsDarkCloudCover())
            {
                CandleStickPattern = eCandlePatterns.DarkCloudCover;
            }
            else if (IsEngulfingPatterns())
            {
                CandleStickPattern = eCandlePatterns.EngulfingPatterns;
            }
            else if (IsPiercingLine())
            {
                CandleStickPattern = eCandlePatterns.PiercingLine;
            }
            else if (IsCandlestickSandwich())
            {
                CandleStickPattern = eCandlePatterns.CandlestickSandwich;
            }
            else if (IsThreeGreenSoldiers())
            {
                CandleStickPattern = eCandlePatterns.ThreeGreenSoldiers;
            }
        }
                
        /// <summary>
        /// Needs 3 candlesticks to determine and can be a reversal in either direction
        /// </summary>
        /// <returns></returns>
        private bool IsAbandonedBaby()
        {
            return false;
        }

        /// <summary>
        /// Needs 2 candlestics to determine and can be a reversal in either direction
        /// </summary>
        /// <returns></returns>
        private bool IsHaramiCross()
        {
            return false;
        }

        private bool IsDragonFly()
        {
            return false;
        }

        private bool IsMorningStar()
        {
            return false;
        }

        private bool IsEveningStar()
        {
            return false;
        }

        private bool IsGravestone()
        {
            return false;
        }

        private bool IsHammer()
        {
            return false;
        }

        private bool IsInvertedHammer()
        {
            return false;
        }

        private bool IsHangingMan()
        {
            return false;
        }

        private bool IsSpinningTop()
        {
            return false;
        }

        private bool IsShootingStar()
        {
            return false;
        }

        private bool IsUpsideGapWithTwoCrows()
        {
            return false;
        }

        private bool IsDarkCloudCover()
        {
            return false;
        }

        private bool IsEngulfingPatterns()
        {
            return false;
        }

        private bool IsPiercingLine()
        {
            return false;
        }

        private bool IsCandlestickSandwich()
        {
            return false;
        }

        private bool IsThreeGreenSoldiers()
        {
            return false;
        }
    }
}
