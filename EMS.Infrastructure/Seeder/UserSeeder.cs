using EMS.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.Infrastructure.Seeder
{
    public static class UserSeeder
    {
        public static async Task SeedAsync(IServiceProvider service)
        {
            var userManager = service.GetRequiredService<UserManager<ApplicationUser>>();

            if (!await userManager.Users.AnyAsync())
            {
                var admin = new ApplicationUser()
                {
                    UserName = "admin",
                    Email = "admin@Evento.com",
                    FirstName = "Evento",
                    LastName = "Admin",
                    PhoneNumber = "123456",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await userManager.CreateAsync(admin, "P@ssw0rd");
                await userManager.AddToRoleAsync(admin, "Admin");

                var user = new ApplicationUser()
                {
                    Email = "Abdallah@Evento.com",
                    FirstName = "Abdallah",
                    LastName = "Taha",
                    PhoneNumber = "123456",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };
                await userManager.CreateAsync(user, "P@ssw0rd");
                await userManager.AddToRoleAsync(user, "User");
            }
        }
    }
}
