using System.ComponentModel.DataAnnotations;

namespace EMS.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        [Required, MaxLength(120)]
        public string Name { get; set; } = string.Empty;
        [Required, MaxLength(1500)]
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        [Required, MaxLength(50)]
        public string Venue { get; set; } = string.Empty;
        public double Pirce { get; set; }

        public string? ImageUrl { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int NumberOfTickets { get; set; }

        public ICollection<UserBookedEvents> BookedTickets { get; set; } = [];

    }
}
