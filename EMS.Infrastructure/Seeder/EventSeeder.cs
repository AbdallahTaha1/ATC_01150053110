using EMS.Domain.Entities;
using EMS.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.Infrastructure.Seeder
{
    public static class EventSeeder
    {
        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

            if (!await context.Events.AnyAsync())
            {
                context.Events.AddRange(
                    new Event { Name = "Cairo Jazz Festival", Description = "Annual jazz celebration featuring local and international artists.", CategoryId = 1, Venue = "AUC Tahrir Campus", Price = 200, Date = new DateTime(2025, 10, 15), NumberOfTickets = 500 },
                    new Event { Name = "Ramadan Nights at Khan El Khalili", Description = "Traditional musical and spiritual nights during Ramadan.", CategoryId = 2, Venue = "Khan El Khalili", Price = 50, Date = new DateTime(2025, 3, 25), NumberOfTickets = 300 },
                    new Event { Name = "Opera Aida", Description = "Classic performance of Verdi's Aida in its homeland.", CategoryId = 3, Venue = "Cairo Opera House", Price = 300, Date = new DateTime(2025, 12, 10), NumberOfTickets = 250 },
                    new Event { Name = "El Sawy Culturewheel Poetry Night", Description = "A gathering for poetry lovers to share and listen.", CategoryId = 4, Venue = "El Sawy Culturewheel", Price = 70, Date = new DateTime(2025, 6, 20), NumberOfTickets = 150 },
                    new Event { Name = "Nubian Culture Day", Description = "Celebrate Nubian heritage with music, dance, and food.", CategoryId = 5, Venue = "Aswan Cultural Center", Price = 40, Date = new DateTime(2025, 8, 5), NumberOfTickets = 200 },
                    new Event { Name = "Alexandria Mediterranean Film Festival", Description = "Annual film fest showcasing Mediterranean cinema.", CategoryId = 6, Venue = "Bibliotheca Alexandrina", Price = 100, Date = new DateTime(2025, 9, 10), NumberOfTickets = 400 },
                    new Event { Name = "Techne Summit", Description = "Entrepreneurship and tech conference in Alexandria.", CategoryId = 7, Venue = "Bibliotheca Alexandrina", Price = 150, Date = new DateTime(2025, 10, 2), NumberOfTickets = 1000 },
                    new Event { Name = "Handicrafts and Heritage Fair", Description = "Showcasing traditional Egyptian crafts and handmade goods.", CategoryId = 8, Venue = "Cairo International Exhibition Center", Price = 30, Date = new DateTime(2025, 11, 12), NumberOfTickets = 600 },
                    new Event { Name = "Mawlid Al-Nabi Celebration", Description = "Celebration of Prophet Muhammad's birthday with sweets and music.", CategoryId = 9, Venue = "Al-Hussein Mosque Area", Price = 0, Date = new DateTime(2025, 9, 16), NumberOfTickets = 1000 },
                    new Event { Name = "Red Sea Kite Festival", Description = "Colorful kite flying event at the Red Sea coast.", CategoryId = 10, Venue = "El Gouna", Price = 60, Date = new DateTime(2025, 7, 14), NumberOfTickets = 300 },
                    new Event { Name = "Sufi Music Night", Description = "Spiritual Sufi chants and dance performances.", CategoryId = 4, Venue = "Wekalet El-Ghouri", Price = 80, Date = new DateTime(2025, 6, 8), NumberOfTickets = 150 },
                    new Event { Name = "Youth Theater Festival", Description = "Plays performed by young Egyptian talents.", CategoryId = 3, Venue = "Hanager Arts Center", Price = 40, Date = new DateTime(2025, 7, 21), NumberOfTickets = 200 },
                    new Event { Name = "Felucca Night Cruise with Music", Description = "Traditional boat ride on the Nile with live oriental music.", CategoryId = 2, Venue = "Zamalek Nile Dock", Price = 100, Date = new DateTime(2025, 5, 15), NumberOfTickets = 100 },
                    new Event { Name = "Siwa Oasis Date Festival", Description = "Seasonal celebration of date harvest with local traditions.", CategoryId = 5, Venue = "Siwa Oasis", Price = 20, Date = new DateTime(2025, 10, 5), NumberOfTickets = 500 },
                    new Event { Name = "Eid Al-Fitr Fun Fair", Description = "Carnival rides, food, and games for families during Eid.", CategoryId = 9, Venue = "Al-Azhar Park", Price = 30, Date = new DateTime(2025, 4, 2), NumberOfTickets = 800 },
                    new Event { Name = "Luxor Light and Sound Show", Description = "Night-time light show narrating Pharaonic history.", CategoryId = 6, Venue = "Karnak Temple", Price = 120, Date = new DateTime(2025, 8, 18), NumberOfTickets = 400 },
                    new Event { Name = "Book Fair for Kids", Description = "Interactive reading and story workshops for children.", CategoryId = 7, Venue = "Egypt International Book Fair", Price = 10, Date = new DateTime(2025, 1, 20), NumberOfTickets = 300 },
                    new Event { Name = "Pharaohs’ Golden Parade Re-enactment", Description = "Re-enactment of the famous parade celebrating Egypt's history.", CategoryId = 6, Venue = "Tahrir Square", Price = 0, Date = new DateTime(2025, 3, 15), NumberOfTickets = 1000 },
                    new Event { Name = "Alexandria Book Club Meetup", Description = "Monthly book club discussion for literature lovers.", CategoryId = 4, Venue = "Alexandria Library", Price = 20, Date = new DateTime(2025, 5, 9), NumberOfTickets = 100 },
                    new Event { Name = "Zar Healing Ritual", Description = "Experience an ancient Egyptian folk healing ritual with music.", CategoryId = 5, Venue = "Old Cairo", Price = 70, Date = new DateTime(2025, 6, 30), NumberOfTickets = 150 }
                    );

                await context.SaveChangesAsync();
            }
        }
    }
}
