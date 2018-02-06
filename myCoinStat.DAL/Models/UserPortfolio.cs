using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace myCoinStat.DAL
{
    public class UserPortfolio
    {
        public int ID { get; set; }
        public string PortfolioName { get; set; }
        public int UserID { get; set; }
                
        public virtual User User { get; set; }
        public virtual ICollection<OrderBook> OrdersBook { get; set; }
    }
}