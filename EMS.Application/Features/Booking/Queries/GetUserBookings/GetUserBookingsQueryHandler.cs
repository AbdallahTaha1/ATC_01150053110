using EMS.Domain.Abstractions.IServices;
using MediatR;

namespace EMS.Application.Features.Booking.Queries.GetUserBookings
{
    public class GetUserBookingsQueryHandler : IRequestHandler<GetUserBookingsQuery, List<UserBookingDto>>
    {
        private readonly IBookingService _bookingService;

        public GetUserBookingsQueryHandler(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public async Task<List<UserBookingDto>> Handle(GetUserBookingsQuery request, CancellationToken cancellationToken)
        {
            var userEvents = await _bookingService.GetUserBookings();

            var result = new List<UserBookingDto>();

            foreach (var userEvent in userEvents)
            {
                result.Add(new UserBookingDto()
                {
                    Id = userEvent.Id,
                    EventName = userEvent.Event.Name,
                    Venue = userEvent.Event.Venue,
                    PricePerTicket = userEvent.Event.Price,
                    NumberOfTickets = userEvent.NumberOfTickets,
                });
            }
            return result;
        }
    }
}
