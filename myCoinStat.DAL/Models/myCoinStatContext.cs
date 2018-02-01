using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace myCoinStat.DAL.Models
{
    public class myCoinStatContext : DbContext
    {
        public myCoinStatContext() : base(@"Data Source =.\SQLExpress; Initial Catalog = myCoinStatDB; Integrated Security = True; Pooling=False")
        {
        }

        public DbSet<Coin> Coins { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<CoinInExchange> CoinInExchanges { get; set; }
        public DbSet<OrderBook> OrderBooks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPortfolio> UserPortfolios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<PortfolioOrder>().HasRequired(c => c.Protfolio).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<PortfolioOrder>().HasRequired(c => c.OrderBook).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Portfolio>().HasRequired(c => c.Exchange).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Portfolio>().HasRequired(c => c.User).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<UserPortfolio>().HasRequired(c => c.Portfolio).WithMany().WillCascadeOnDelete(false);

            modelBuilder.Entity<UserPortfolio>().HasRequired(c => c.User).WithMany().WillCascadeOnDelete(false);    
            modelBuilder.Entity<UserPortfolio>().HasRequired(u => u.User).WithMany(a => a.UserPortfolios).HasForeignKey(u => u.UserID);

            //modelBuilder.Entity<PortfolioOrder>().HasRequired(o => o.OrderBook).WithMany(u => u.PortfolioOrders).HasForeignKey(o => o.OrderBookID);
            //modelBuilder.Entity<PortfolioOrder>().HasRequired(p => p.Protfolio).WithMany(u => u.PortfolioOrders).HasForeignKey(p => p.PortfolioID);
        }
    }
}