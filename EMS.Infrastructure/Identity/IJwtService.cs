using EMS.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;

namespace EMS.Infrastructure.Identity
{
    public interface IJwtService
    {
        Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user);
    }
}
