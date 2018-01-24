using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using myCoinStat.Models;

namespace myCoinStat.DAL
{
    public class myCoinStatInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<myCoinStatContext>
    {
        protected override void Seed(myCoinStatContext context)
        {
        }
    }
}