using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace myCoinStat.DAL.Models
{
    public class UserPortfolio
    {
        public int ID { get; set; }

        [ForeignKey("Portfolio"),DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PortfolioID { get; set; }

        //[ForeignKey("User"), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public virtual Portfolio Portfolio { get; set; }
        public virtual User User { get; set; }
    }
}