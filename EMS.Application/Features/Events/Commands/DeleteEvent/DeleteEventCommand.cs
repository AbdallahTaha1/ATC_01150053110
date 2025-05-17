using MediatR;

namespace EMS.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
