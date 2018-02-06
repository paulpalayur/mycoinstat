using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    public class CoinRepository : Repository<Coin>, ICoinRepository
    {
        public CoinRepository(myCoinStatContext context) : base(context)
        { }

    }
}
