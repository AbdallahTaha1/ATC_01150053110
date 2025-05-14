using EMS.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace EMS.Infrastructure.Identity
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor?.HttpContext?.User.FindFirstValue("uid");
        }
        public string? UserId { get; }
    }
}
