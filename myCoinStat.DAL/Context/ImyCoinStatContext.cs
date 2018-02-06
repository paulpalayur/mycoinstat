using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace myCoinStat.DAL
{
    interface ImyCoinStatContext : IDisposable
    {
        IDbSet<Coin> Coins { get; set; }
        IDbSet<Exchange> Exchanges { get; set; }
        IDbSet<CoinInExchange> CoinInExchanges { get; set; }
        IDbSet<OrderBook> OrderBooks { get; set; }
        IDbSet<User> Users { get; set; }
        int SaveChanges();
    }
}        