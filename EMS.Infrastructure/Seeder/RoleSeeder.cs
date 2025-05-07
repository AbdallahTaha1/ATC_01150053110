using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.Infrastructure.Seeder
{
    public static class RoleSeeder
    {
        public static async Task SeedAsync(IServiceProvider service)
        {
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.Roles.AnyAsync())
            {
                await roleManager.CreateAsync(new IdentityRole() { Name = "Admin" });
                await roleManager.CreateAsync(new IdentityRole() { Name = "User" });
            }
        }
    }
}
