using EMS.Application.Features.Account.Commands;
using EMS.Application.Features.Account.Commands.RegisterUser;

namespace EMS.Application.Common.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResultDto> AuthenticatAsync(string email, string password);
        Task<AuthResultDto> RegisterAsync(RegisterUserCommand model);
    }
}
