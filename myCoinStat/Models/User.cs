﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myCoinStat.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}