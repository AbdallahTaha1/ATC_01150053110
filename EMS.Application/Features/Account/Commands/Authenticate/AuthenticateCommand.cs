using MediatR;

namespace EMS.Application.Features.Account.Commands.Authenticate
{
    public class AuthenticateCommand : IRequest<AuthResultDto>
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
