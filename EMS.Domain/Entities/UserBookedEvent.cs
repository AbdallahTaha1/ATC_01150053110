namespace EMS.Domain.Entities
{
    public class UserBookedEvent
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; } = string.Empty;
        public ApplicationUser User { get; set; } = default!;
        public int EventId { get; set; }
        public Event Event { get; set; } = default!;
        public int NumberOfTickets { get; set; }
    }
}
