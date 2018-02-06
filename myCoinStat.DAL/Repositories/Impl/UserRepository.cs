using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCoinStat.DAL
{
    public class UserRepository:Repository<User>,IUserRepository
    {
        public UserRepository(myCoinStatContext context) : base(context)
        { }
    }
}
