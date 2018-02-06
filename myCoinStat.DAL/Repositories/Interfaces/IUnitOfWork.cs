using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository Users { get; }
        IUserPortfolioRepository UserPortfolios { get; }
        IOrderBookRepository OrdersBook { get; }
        ICoinRepository Coins { get; }
        IExchangeRepository Exchanges { get; }
        ICoinInExchangeRepository CoinsInExchanges { get; }
        int SaveChanges();
    }
}
