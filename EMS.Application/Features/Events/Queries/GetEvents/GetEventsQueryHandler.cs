using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Events.Queries.GetEvents
{
    public class GetEventsCommandHandler : IRequestHandler<GetEventsQuery, IEnumerable<Event>?>
    {
        private readonly IEventService _eventService;

        public GetEventsCommandHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IEnumerable<Event>?> Handle(GetEventsQuery request, CancellationToken cancellationToken)
        {
            return await _eventService.GetEventsAsync();
        }
    }
}
