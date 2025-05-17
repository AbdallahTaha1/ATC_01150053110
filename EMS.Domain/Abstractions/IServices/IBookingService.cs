
using EMS.Domain.Entities;

namespace EMS.Domain.Abstractions.IServices
{
    public interface IBookingService
    {
        Task BookEventAsync(int eventId, int numberOfTickets);
        Task<List<UserBookedEvent>> GetUserBookings();
    }
}
