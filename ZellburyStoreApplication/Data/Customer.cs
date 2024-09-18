using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZellburyStoreApplication.Data
{
    public class Customer : IdentityUser
    {

        public String Firstname { get; set; }
        public String LastName { get; set; }
        public String PhoneNo { get; set; }
        public String Address { get; set; }

    }
}
