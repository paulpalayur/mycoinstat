using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    public class OrderBookRepository:Repository<OrderBook>,IOrderBookRepository
    {
        public OrderBookRepository(myCoinStatContext context) : base(context)
        { }

        public IEnumerable<OrderBook> GetAllTrades(int UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderBook> GetAllTradesForCoin(int UserId, int UserPorfolioId, int CoinInExchangeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderBook> GetAllTradesInPorfolio(int UserId, int UserPorfolioId)
        {
            throw new NotImplementedException();
        }

        public myCoinStatContext myCoinStatContext
        {
            get { return _context as myCoinStatContext; }
        }
    }
}
