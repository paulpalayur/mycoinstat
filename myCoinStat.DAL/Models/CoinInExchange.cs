using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL.Models
{
    public class CoinInExchange
    {
        public int ID { get; set; }
        public int CoinID { get; set; }
        public int ExchangeID { get; set; }

        public virtual Coin Coin { get; set; }
        public virtual Exchange Exchange { get; set; }
        public virtual ICollection<OrderBook> OrderBooks { get; set; }

    }
}