using StockAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAlgorithms.Models
{
    class ClusterCandle : Stock
    {
        List<Stock> _cluster = new List<Stock>();

        public List<Stock> Cluster
        {
            get
            {
                return _cluster;
            }
        }

        public ClusterCandle(DateTime startDate)
        {

        }
    }
}
