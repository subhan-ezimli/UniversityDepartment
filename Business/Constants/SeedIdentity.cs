using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {

            var roles = await roleManager.Roles.ToListAsync();
            if (!roles.Contains(new IdentityRole("candidate")))
            {
                var resultaa = await roleManager.CreateAsync(new IdentityRole("candidate"));
            }
            await roleManager.CreateAsync(new IdentityRole("teacher"));
            await roleManager.CreateAsync(new IdentityRole("admin"));

            var username = configuration["Data:AdminUser:username"];
            var email = configuration["Data:AdminUser:email"];
            var password = configuration["Data:AdminUser:password"];
            var role = configuration["Data:AdminUser:role"];

            if (await userManager.FindByNameAsync(username) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));

                var user = new User()
                {
                    UserName = username,
                    Email = email,
                    Name = "admin",
                    EmailConfirmed = true,
                    SurName = "admin",
                    Gender = Entites.Enum.Gender.Male,
                    BirthDate = DateTime.Now.AddYears(22)
                };


                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
