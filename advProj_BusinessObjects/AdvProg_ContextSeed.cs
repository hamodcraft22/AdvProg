using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advProj_BusinessObjects
{
    public class AdvProg_ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<AdvProg_ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // custome roles creation 
            if (!roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
        }

        public static async Task SeedAdminAsync(UserManager<AdvProg_ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // seed defult user 
            var defultUser = new AdvProg_ApplicationUser
            {
                UserName = "admin",
                Email = "admin@admin.com",
                fName = "Admin",
                lName = "Luwastnamee",
                PhoneNumber = "97337702893",
                Department = "Administration",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defultUser.Id))
            {
                var user = await userManager.FindByNameAsync(defultUser.UserName);
                if (user == null)
                {
                    await userManager.CreateAsync(defultUser, "Admin@Qwerty_123456");
                    await userManager.AddToRoleAsync(defultUser, "Admin");

                    // adding the user to the list of users in the normal database context
                    AdvProg_DatabaseContext databaseContext = new AdvProg_DatabaseContext();
                    AdvProjUser newUser = new AdvProjUser();
                    newUser.AspUserId = defultUser.Id;
                    databaseContext.Add(newUser);
                    databaseContext.SaveChanges();
                }
            }
        }

    }
}
