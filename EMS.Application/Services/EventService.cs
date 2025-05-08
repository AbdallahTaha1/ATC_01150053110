using EMS.Domain.Abstractions;
using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;

namespace EMS.Application.Services
{
    public class EventService : IEventService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EventService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Event>?> GetEventsAsync()
        {
            return await _unitOfWork.Events.GetAllAsync();
        }

        public async Task<Event?> GetEventByIdAsync(int eventId)
        {
            return await _unitOfWork.Events.GetByIdAsync(eventId);
        }
        public async Task<int> AddEventAsync(Event Newevent)
        {
            var NewEvent = _unitOfWork.Events.Add(Newevent);
            await _unitOfWork.SaveChangesAsync();
            return NewEvent.Id;
        }


    }
}