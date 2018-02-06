using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    class UserPortfolioRepository:Repository<UserPortfolio>,IUserPortfolioRepository
    {
        public UserPortfolioRepository(myCoinStatContext context) : base(context)
        { }
    }
}
