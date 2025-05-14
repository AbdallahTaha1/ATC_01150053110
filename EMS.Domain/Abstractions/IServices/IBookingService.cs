
namespace EMS.Domain.Abstractions.IServices
{
    public interface IBookingService
    {
        Task BookEventAsync(int eventId);
    }
}
