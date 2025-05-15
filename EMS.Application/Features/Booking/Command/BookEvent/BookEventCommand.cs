using MediatR;

namespace EMS.Application.Features.Booking.Command.BookEvent
{
    public class BookEventCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int NumberOfTickets { get; set; }
    }
}
