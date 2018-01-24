using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.Models
{
    public class PortfolioOrder
    {
        public int ID { get; set; }
        public int PortfolioID { get; set; }
        public int OrderBookID { get; set; }

        public virtual Portfolio Protfolio { get; set; }
        public virtual OrderBook OrderBook { get; set; }
    }
}