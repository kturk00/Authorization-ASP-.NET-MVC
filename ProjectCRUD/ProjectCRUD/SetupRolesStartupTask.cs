using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCRUD
{
    public class SetupRolesStartupTask : IStartupTask
    {
        public async Task Execute(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            string[] roleNames = { "Admin", "Superuser", "User" };
            IdentityResult roleResult;
            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            var _user = await UserManager.FindByEmailAsync("admin@email.com");

            if (_user == null)
            {
  
                var poweruser = new IdentityUser
                {
                    UserName = "Admin",
                    Email = "admin@email.com",
                };
                string adminPassword = "Adminx123!";

                var createPowerUser = await UserManager.CreateAsync(poweruser, adminPassword);
                if (createPowerUser.Succeeded)
                {
                    await UserManager.AddToRoleAsync(poweruser, "Admin");

                }
            }

            var _user2 = await UserManager.FindByNameAsync("Superuser1");

            if (_user2 == null)
            {

                var superuser = new IdentityUser
                {
                    UserName = "Superuser1",
                    Email = "superuser1@email.com",
                };
                string adminPassword = "Suserx123!";

                var createSuperUser = await UserManager.CreateAsync(superuser, adminPassword);
                if (createSuperUser.Succeeded)
                {
                    await UserManager.AddToRoleAsync(superuser, "Superuser");

                }
            }
        }
    }
}
