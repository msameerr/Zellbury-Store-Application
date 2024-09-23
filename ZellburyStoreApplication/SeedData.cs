using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZellburyStoreApplication.Data;

namespace ZellburyStoreApplication
{
    public static class SeedData
    {

        public static void Seed(UserManager<Customer> userManager, RoleManager<IdentityRole> roleManager)
        {

            SeedRoles(roleManager);
            SeedUsers(userManager);

        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {

            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole { Name = "Administrator" };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Customer").Result)
            {
                var role = new IdentityRole { Name = "Customer" };
                var result = roleManager.CreateAsync(role).Result;
            }

        }


        private static void SeedUsers(UserManager<Customer> userManager)
        {

            var users = userManager.GetUsersInRoleAsync("Customer").Result;

            if (userManager.FindByNameAsync("admin@localhost.com").Result == null)
            {

                var user = new Customer
                {
                    UserName = "admin@localhost.com",
                    Email = "admin@localhost.com"
                };
                var result = userManager.CreateAsync(user, "Pakistan@1").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }

            }

        }


    }
}
