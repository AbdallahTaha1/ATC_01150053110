using EMS.Domain.Abstractions.IServices;
using MediatR;

namespace EMS.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand, bool>
    {
        private readonly IEventService _eventService;
        public DeleteEventCommandHandler(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<bool> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            return await _eventService.DeleteEventAsync(request.Id);

        }
    }
}
