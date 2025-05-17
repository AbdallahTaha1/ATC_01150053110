using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Events.Commands.EditEvent
{
    public class EditEventCommmandHandler : IRequestHandler<EditEventCommmand, Event?>
    {
        private readonly IEventService _eventService;

        public EditEventCommmandHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<Event?> Handle(EditEventCommmand request, CancellationToken cancellationToken)
        {
            var evnt = await _eventService.GetEventByIdAsync(request.Id);

            if (evnt == null) return evnt;

            evnt.Price = request.Price;
            evnt.CategoryId = request.CategoryId;
            evnt.Date = request.Date;
            evnt.Description = request.Description;
            evnt.ImageUrl = request.ImageUrl;
            evnt.Venue = request.Venue;
            evnt.Name = request.Name;

            return await _eventService.EditEventAsync(evnt);
        }
    }
}
