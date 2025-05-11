using MediatR;
using System.ComponentModel.DataAnnotations;

namespace EMS.Application.Features.Account.Commands.RegisterUser
{
    public class RegisterUserCommand : IRequest<AuthResultDto>
    {
        [Required, StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required, StringLength(128)]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(256)]
        public string Password { get; set; } = string.Empty;
    }
}
