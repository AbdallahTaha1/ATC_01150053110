using MediatR;

namespace EMS.Application.Features.Events.Queries.GetEventById
{
    public class GetEventByIdQuery : IRequest<EventDto?>
    {
        public int Id { get; set; }

    }
}
