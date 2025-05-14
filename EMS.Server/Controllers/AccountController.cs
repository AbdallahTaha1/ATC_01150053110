using EMS.Application.Features.Account.Commands;
using EMS.Application.Features.Account.Commands.Authenticate;
using EMS.Application.Features.Account.Commands.RegisterUser;
using EMS.Application.Features.Account.Queries.GetAllUsers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ISender _sender;

        public AccountController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("registerUser")]
        [ProducesResponseType(typeof(AuthResultDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> RegisterUserAsync(RegisterUserCommand request)
        {

            return Ok(await _sender.Send(request));
        }


        [HttpPost("authenticate")]
        [ProducesResponseType(typeof(AuthResultDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> AuthenticateAsync(AuthenticateCommand request)
        {
            return Ok(await _sender.Send(request));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            return Ok(await _sender.Send(new GetAllUsersQuery()));

        }
        /*
        [HttpPost("requestJwt")]
        [ProducesResponseType(typeof(AuthResultDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> RequestJWTAsync(RequestJWTTokenCommand request)
        {
            return Ok(await _sender.Send(request));
        }

        [HttpPost("changePassword")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Authorize]
        public async Task<IActionResult> ChangePasswordAsync(ChangePasswordCommand request)
        {
            await _sender.Send(request);
            return NoContent();
        }
        */

    }
}
