using Microsoft.AspNetCore.Identity;
using RealestateApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealestateApplication.Data
{
    public class Initial
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();
            
            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("ekunic1@etf.unsa.ba") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "ekunic1@etf.unsa.ba",
                    Email = "ekunic1@etf.unsa.ba",
                    FirstName = "Edis",
                    LastName = "Kunic",
                    Street = "Haljinici",
                    City = "Kakanj",
                    Province = "ZDK",
                    PostalCode = "72245",
                    Country = "Bosnia and Herzegovina",
                    PhoneNumber = "062112488"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
            }
        }
    }
}
