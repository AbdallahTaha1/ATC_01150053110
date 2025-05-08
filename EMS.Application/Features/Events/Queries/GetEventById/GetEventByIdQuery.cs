using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Events.Queries.GetEventById
{
    public class GetEventByIdQuery : IRequest<Event?>
    {
        public int Id { get; set; }

    }
}
