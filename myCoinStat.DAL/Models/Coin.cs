﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL
{
    public class Coin
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CoinInExchange> CoinInExchanges { get; set; }
    }
}