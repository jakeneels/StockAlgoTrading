using System;

namespace DatabaseService.Models
{
    [Serializable]
    public class Stock
    {
        public enum eTransactionType
        {
            Sell = 1,
            Buy = 2
        }

        public string Symbol { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double Price { get; set; }
        public eTransactionType TransactionType { get; set; }
    }
}
