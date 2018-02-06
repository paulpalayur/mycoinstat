using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    class ExchangeRepository:Repository<Exchange>,IExchangeRepository
    {
        public ExchangeRepository(myCoinStatContext context) : base(context)
        { }
    }
}
