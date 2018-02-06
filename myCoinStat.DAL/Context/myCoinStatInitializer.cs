using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace myCoinStat.DAL
{
    public class myCoinStatInitializer : DropCreateDatabaseAlways<myCoinStatContext>
    {
        protected override void Seed(myCoinStatContext context)
        {            
            var users = new List<User>
            {
                new User { FirstName = "Paul", LastName = "Palayur", Password = "Password01", EmailId = "paulpalayur@gmail.com" },
                new User { FirstName = "Joseph", LastName = "Francis", Password = "Password01", EmailId = "josephfrancis@gmail.com" }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}