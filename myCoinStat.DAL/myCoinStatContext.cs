//using myCoinStat.Models;
//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;

//namespace myCoinStat.DAL
//{
//    public class myCoinStatContext:DbContext
//    {
//        public myCoinStatContext() : base("myCoinStatContext")
//        {
//        }

//        public DbSet<Coin> Coins { get; set; }
//        public DbSet<Exchange> Exchanges { get; set; }
//        public DbSet<CoinInExchange> CoinInExchanges { get; set; }
//        public DbSet<OrderBook> OrderBooks { get; set; }
//        public DbSet<Portfolio> Portfolios { get; set; }
//        public DbSet<PortfolioOrder> PortfolioOrders { get; set; }
//        public DbSet<User> Users { get; set; }
        
//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
//        }
//    }
//}