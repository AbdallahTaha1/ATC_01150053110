namespace EMS.Application.Features.Booking.Queries
{
    public class UserBookingDto
    {
        public int Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string Venue { get; set; } = string.Empty;
        public int NumberOfTickets { get; set; }
        public double PricePerTicket { get; set; }
    }
}
