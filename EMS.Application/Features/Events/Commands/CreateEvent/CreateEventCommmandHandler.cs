using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommmandHandler : IRequestHandler<CreateEventCommmand, int>
    {
        private readonly IEventService _eventService;

        public CreateEventCommmandHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<int> Handle(CreateEventCommmand request, CancellationToken cancellationToken)
        {
            var newEvent = new Event()
            {
                Name = request.Name,
                CategoryId = request.CategoryId,
                Description = request.Description,
                Venue = request.Venue,
                Pirce = request.Pirce,
                ImageUrl = request.ImageUrl,
                Date = request.Date,
                NumberOfTickets = request.NumberOfTickets
            };

            return await _eventService.AddEventAsync(newEvent);

        }
    }
}
