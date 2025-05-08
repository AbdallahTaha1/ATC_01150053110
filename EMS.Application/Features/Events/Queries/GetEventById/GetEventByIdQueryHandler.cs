using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Events.Queries.GetEventById
{
    public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, Event?>
    {
        private readonly IEventService _eventService;

        public GetEventByIdQueryHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<Event?> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _eventService.GetEventByIdAsync(request.Id);
            return result;
        }
    }
}
