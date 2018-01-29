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
        //protected override void Seed(myCoinStatContext context)
        //{
        //    //context.Users.Add(new User { FirstName = "Paul", LastName = "Palayur", Password = "Password01", EmailId = "paulpalayur@gmail.com" });

        //    var users = new List<User>
        //    {
        //        new User { FirstName = "Paul", LastName = "Palayur", Password = "Password01", EmailId = "paulpalayur@gmail.com" },
        //        new User { FirstName = "Joseph", LastName = "Francis", Password = "Password01", EmailId = "josephfrancis@gmail.com" }
        //    };

        //    users.ForEach(u => context.Users.Add(u));
        //    context.SaveChanges();

        //}
    }
}