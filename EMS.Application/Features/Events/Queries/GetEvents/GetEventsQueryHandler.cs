using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Events.Queries.GetEvents
{
    public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, IEnumerable<EventDto>?>
    {
        private readonly IEventService _eventService;

        public GetEventsQueryHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IEnumerable<EventDto>?> Handle(GetEventsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Event> events = await _eventService.GetEventsAsync();


            var result = new List<EventDto>();

            foreach (var evnt in events)
                result.Add(new EventDto()
                {
                    Id = evnt.Id,
                    Name = evnt.Name,
                    Date = evnt.Date,
                    Description = evnt.Description,
                    Price = evnt.Price,
                    ImageUrl = evnt.ImageUrl,
                    Venue = evnt.Venue,
                    NumberOfTickets = evnt.NumberOfTickets,
                    CategoryName = evnt.Category.Name
                });

            return result;
        }
    }
}
