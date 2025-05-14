using EMS.Domain.Abstractions.IServices;
using EMS.Domain.Entities;
using MediatR;

namespace EMS.Application.Features.Account.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<ApplicationUser>?>
    {
        private readonly IUserService _userService;

        public GetAllUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IEnumerable<ApplicationUser>?> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userService.GetUsersAsync();
        }
    }
}
