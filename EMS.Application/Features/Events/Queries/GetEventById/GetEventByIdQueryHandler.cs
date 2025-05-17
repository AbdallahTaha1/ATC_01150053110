using EMS.Domain.Abstractions.IServices;
using MediatR;

namespace EMS.Application.Features.Events.Queries.GetEventById
{
    public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, EventDto?>
    {
        private readonly IEventService _eventService;

        public GetEventByIdQueryHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<EventDto?> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _eventService.GetEventByIdAsync(request.Id);

            if (result == null) return null;

            var eventDto = new EventDto()
            {
                Id = result.Id,
                Name = result.Name,
                Date = result.Date,
                Description = result.Description,
                Venue = result.Venue,
                CategoryName = result.Category.Name,
                NumberOfTickets = result.NumberOfTickets,
                Price = result.Price,
                ImageUrl = result.ImageUrl
            };
            return eventDto;
        }
    }
}
