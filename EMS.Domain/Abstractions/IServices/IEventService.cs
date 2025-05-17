using EMS.Domain.Entities;

namespace EMS.Domain.Abstractions.IServices
{
    public interface IEventService
    {
        Task<int> AddEventAsync(Event Newevent);
        Task<Event?> GetEventByIdAsync(int eventId);
        Task<IEnumerable<Event>> GetEventsAsync();

        Task<Event?> EditEventAsync(Event evnt);

        Task<bool> DeleteEventAsync(int eventId);
    }
}
