using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL
{
    public class OrderBook
    {
        public int ID { get; set; }
        public int CoinInExchangeID { get; set; }
        public int UserPortfolioID { get; set; }
        public decimal Quantity { get; set; }
        public decimal CoinPrice { get; set; }
        public string BuyOrSell { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual CoinInExchange CoinInExchange { get; set; }
        public virtual UserPortfolio UserPortfolio { get; set; }
    }
}