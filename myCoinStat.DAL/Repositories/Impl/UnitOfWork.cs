using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly myCoinStatContext _context;
        public UnitOfWork(myCoinStatContext context)
        {
            _context = context;
        }

        public ICoinRepository Coins{ get; }
        public ICoinInExchangeRepository CoinsInExchanges { get; }
        public IExchangeRepository Exchanges { get; }
        public IOrderBookRepository OrdersBook { get; }
        public IUserPortfolioRepository UserPortfolios { get; }
        public IUserRepository Users { get; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
