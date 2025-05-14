using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Account.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<IEnumerable<ApplicationUser>?>
    {
    }
}
