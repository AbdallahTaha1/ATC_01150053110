using EMS.Application.Common.Interfaces;
using MediatR;

namespace EMS.Application.Features.Account.Commands.Authenticate
{
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, AuthResultDto>
    {
        private readonly IAuthService _authService;

        public AuthenticateCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<AuthResultDto> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var result = await _authService.AuthenticatAsync(request.Email, request.Password);
            return result;
        }
    }
}
