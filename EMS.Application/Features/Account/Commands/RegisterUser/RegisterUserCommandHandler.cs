using EMS.Application.Common.Interfaces;
using MediatR;

namespace EMS.Application.Features.Account.Commands.RegisterUser
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, AuthResultDto>
    {
        private readonly IAuthService _authService;

        public RegisterUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public Task<AuthResultDto> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var result = _authService.RegisterAsync(request);

            return result;
        }
    }
}
