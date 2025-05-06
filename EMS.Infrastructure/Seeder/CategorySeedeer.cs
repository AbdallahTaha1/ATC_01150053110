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
                    new Category { Id = 1, Name = "Music Festival" },
                    new Category { Id = 2, Name = "Cultural Night" },
                    new Category { Id = 3, Name = "Theater & Performance" },
                    new Category { Id = 4, Name = "Literature & Poetry" },
                    new Category { Id = 5, Name = "Traditional & Heritage" },
                    new Category { Id = 6, Name = "Historical & Educational" },
                    new Category { Id = 7, Name = "Technology & Conferences" },
                    new Category { Id = 8, Name = "Handicrafts & Markets" },
                    new Category { Id = 9, Name = "Religious Celebrations" },
                    new Category { Id = 10, Name = "Outdoor & Nature" },
                    new Category { Id = 11, Name = "Food & Culinary" },
                    new Category { Id = 12, Name = "Youth & Family" },
                    new Category { Id = 13, Name = "Cinema & Film" },
                    new Category { Id = 14, Name = "Workshops & Training" },
                    new Category { Id = 15, Name = "Art & Exhibitions" }
                    );

                await context.SaveChangesAsync();
            }
        }
    }
}
