using MediatR;

namespace EMS.Application.Features.Events.Queries.GetEvents
{
    public class GetEventsQuery : IRequest<IEnumerable<EventDto>?>
    {
    }
}
