namespace EMS.Application.Features.Events.Queries
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Venue { get; set; } = string.Empty;
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfTickets { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
