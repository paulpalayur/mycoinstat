using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using myCoinStat.DAL.Models;

namespace myCoinStat.DAL.Context
{
    public class myCoinStatContext : DbContext, ImyCoinStatContext
    {
        public myCoinStatContext() : base(ConfigurationManager.ConnectionStrings["myCoinStatContext"].ToString())
        {
        }

        public IDbSet<Coin> Coins { get; set; }
        public IDbSet<Exchange> Exchanges { get; set; }
        public IDbSet<CoinInExchange> CoinInExchanges { get; set; }
        public IDbSet<OrderBook> OrderBooks { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<UserPortfolio> UserPortfolios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<UserPortfolio>().HasRequired(c => c.User).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<UserPortfolio>().HasRequired(u => u.User).WithMany(a => a.UserPortfolios).HasForeignKey(u => u.UserID);
        }
    }
}