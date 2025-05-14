using EMS.Application.Common.Interfaces;
using EMS.Domain.Abstractions;
using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;

namespace EMS.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IUnitOfWork _unitOfWork;

        public BookingService(ICurrentUserService currentUserService, IUnitOfWork unitOfWork)
        {
            _currentUserService = currentUserService;
            _unitOfWork = unitOfWork;
        }

        public async Task BookEventAsync(int eventId)
        {
            var userId = _currentUserService.UserId;
            if (string.IsNullOrEmpty(userId))
                throw new UnauthorizedAccessException("User is not logged in.");

            var evnt = await _unitOfWork.Events.GetByIdAsync(eventId);
            if (evnt == null)
                throw new KeyNotFoundException("Event not found");

            var alreadyBooked = await _unitOfWork.UserEvents
                .FindAllAsync(x => x.EventId == eventId && x.ApplicationUserId == userId);
            if (alreadyBooked.Count != 0)
                throw new InvalidOperationException("User already booked this event.");

            var booking = new UserBookedEvent
            {
                EventId = eventId,
                ApplicationUserId = userId,
            };


            _unitOfWork.UserEvents.Add(booking);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
