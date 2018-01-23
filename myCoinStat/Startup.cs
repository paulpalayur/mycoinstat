using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myCoinStat.Startup))]
namespace myCoinStat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
