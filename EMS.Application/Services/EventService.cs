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
        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            return await _unitOfWork.Events.GetAllAsync(["Category"]);
        }

        public async Task<Event?> GetEventByIdAsync(int eventId)
        {
            return await _unitOfWork.Events.FindAsync(e => e.Id == eventId, ["Category"]);
        }
        public async Task<int> AddEventAsync(Event evnt)
        {
            var NewEvent = _unitOfWork.Events.Add(evnt);
            await _unitOfWork.SaveChangesAsync();
            return NewEvent.Id;
        }

        public async Task<Event?> EditEventAsync(Event evnt)
        {
            var result = _unitOfWork.Events.Update(evnt);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task<bool> DeleteEventAsync(int eventId)
        {
            var evnt = await _unitOfWork.Events.GetByIdAsync(eventId);

            if (evnt == null) return false;

            _unitOfWork.Events.Delete(evnt);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}