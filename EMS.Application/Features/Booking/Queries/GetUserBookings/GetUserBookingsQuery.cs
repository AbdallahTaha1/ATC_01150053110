using MediatR;

namespace EMS.Application.Features.Booking.Queries.GetUserBookings
{
    public class GetUserBookingsQuery : IRequest<List<UserBookingDto>>
    {
    }
}
