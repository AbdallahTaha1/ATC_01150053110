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

        public async Task BookEventAsync(int eventId, int numberOfTickets)
        {
            var userId = _currentUserService.UserId;
            if (string.IsNullOrEmpty(userId))
                throw new UnauthorizedAccessException("User is not logged in.");

            var evnt = await _unitOfWork.Events.GetByIdAsync(eventId);
            if (evnt == null)
                throw new KeyNotFoundException("Event not found");

            if (numberOfTickets > evnt.NumberOfTickets)
                throw new InvalidOperationException("No enough tickets");

            var booking = new UserBookedEvent
            {
                EventId = eventId,
                ApplicationUserId = userId,
                NumberOfTickets = numberOfTickets
            };


            _unitOfWork.UserEvents.Add(booking);
            var result = await _unitOfWork.SaveChangesAsync();

            if (result > 0)
            {
                evnt.NumberOfTickets -= numberOfTickets;
                await _unitOfWork.SaveChangesAsync();
            }
        }
    }
}
