using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using myCoinStat.DAL;

namespace myCoinStat
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseAlways<myCoinStatContext>());
            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<myCoinStatContext>());
            using (var context = new myCoinStatContext())
            {
                context.Database.Initialize(force: true);
            }
        }
    }
}
