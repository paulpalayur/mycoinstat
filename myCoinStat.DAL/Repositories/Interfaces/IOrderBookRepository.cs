using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    public interface IOrderBookRepository : IRepository<OrderBook>
    {
        IEnumerable<OrderBook> GetAllTrades(int UserId);
        IEnumerable<OrderBook> GetAllTradesInPorfolio(int UserId,int UserPorfolioId);
        IEnumerable<OrderBook> GetAllTradesForCoin(int UserId, int UserPorfolioId,int CoinInExchangeId);
    }
}
