using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL.Models
{
    public class UserPortfolio
    {
        public int ID { get; set; }
        public int PortfolioID { get; set; }
        public int UserID { get; set; }

        public virtual Portfolio Portfolio { get; set; }
        public virtual User User { get; set; }
    }
}