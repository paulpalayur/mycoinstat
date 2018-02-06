using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace myCoinStat.DAL
{
    class PortfolioOrder_DoNotUse
    {
        public int ID { get; set; }

        //[ForeignKey("Portfolio"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PortfolioID { get; set; }

        //[ForeignKey("OrderBook"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderBookID { get; set; }

        //public virtual Portfolio Protfolio { get; set; }
        public virtual OrderBook OrderBook { get; set; }
    }
}