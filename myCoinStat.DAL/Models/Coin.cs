using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL.Models
{
    public class Coin
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Coin> CoinInExchanges { get; set; }
    }
}