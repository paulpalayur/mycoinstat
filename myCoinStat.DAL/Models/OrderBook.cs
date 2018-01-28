using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL.Models
{
    public class OrderBook
    {
        public int ID { get; set; }
        public int CoinInExchangeID { get; set; }
        public int UserID { get; set; }
        public int PortfolioID { get; set; }
        public decimal Quantity { get; set; }
        public decimal CoinPrice { get; set; }
        public string BuyOrSell { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual CoinInExchange CoinInExchange { get; set; }
        public virtual User User { get; set; }
        public virtual Portfolio Portfolio { get; set; }
        public virtual ICollection<PortfolioOrder> PortfolioOrder { get; set; }
    }
}