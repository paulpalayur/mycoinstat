using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL.Models
{
    class Portfolio_DoNotUse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public int ExchangeID { get; set; }

        public virtual User User { get; set; }
        public virtual Exchange Exchange { get; set; }
        //public virtual ICollection<PortfolioOrder> PortfolioOrders { get; set; }
    }
}