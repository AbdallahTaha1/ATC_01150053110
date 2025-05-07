using EMS.Domain.Entities;
using EMS.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.Infrastructure.Seeder
{
    public static class CategorySeedeer
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

            if (!await context.Categories.AnyAsync())
            {
                context.Categories.AddRange(
                    new Category { Name = "Music Festival" },
                    new Category { Name = "Cultural Night" },
                    new Category { Name = "Theater & Performance" },
                    new Category { Name = "Literature & Poetry" },
                    new Category { Name = "Traditional & Heritage" },
                    new Category { Name = "Historical & Educational" },
                    new Category { Name = "Technology & Conferences" },
                    new Category { Name = "Handicrafts & Markets" },
                    new Category { Name = "Religious Celebrations" },
                    new Category { Name = "Outdoor & Nature" },
                    new Category { Name = "Food & Culinary" },
                    new Category { Name = "Youth & Family" },
                    new Category { Name = "Cinema & Film" },
                    new Category { Name = "Workshops & Training" },
                    new Category { Name = "Art & Exhibitions" }
                    );

                await context.SaveChangesAsync();
            }
        }
    }
}
