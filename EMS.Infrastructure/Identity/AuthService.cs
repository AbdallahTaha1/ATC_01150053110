using EMS.Application.Common.Interfaces;
using EMS.Application.Features.Account.Commands;
using EMS.Application.Features.Account.Commands.RegisterUser;
using EMS.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;

namespace EMS.Infrastructure.Identity
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtService _jwtService;
        public AuthService(UserManager<ApplicationUser> userManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _jwtService = jwtService;
        }

        public async Task<AuthResultDto> RegisterAsync(RegisterUserCommand model)
        {
            if (await _userManager.FindByEmailAsync(model.Email) is not null)
                return new AuthResultDto { Message = "Email is already registered!" };

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                    errors += $"{error.Description},";

                return new AuthResultDto { Message = errors };
            }

            await _userManager.AddToRoleAsync(user, "User");

            var jwtSecurityToken = await _jwtService.CreateJwtToken(user);

            return new AuthResultDto
            {
                Email = user.Email,
                JWTTokenExpiresOn = jwtSecurityToken.ValidTo,
                IsAuthenticated = true,
                Roles = new List<string> { "User" },
                JWTToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Name = $"{model.FirstName} {model.LastName}",
            };
        }

        public async Task<AuthResultDto> AuthenticatAsync(string email, string password)
        {
            var authModel = new AuthResultDto();
            // 1. Find user by email
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
            {
                authModel.Message = "There is no user registerd with this email!";
                return authModel;
            }

            // 2. Check Password
            if (!await _userManager.CheckPasswordAsync(user, password))
            {
                authModel.Message = "Incorrect Password!";
                return authModel;
            }

            // 3. Create Jwt Token
            var jwtSecurityToken = await _jwtService.CreateJwtToken(user);

            // 4. Get User Role
            var rolesList = await _userManager.GetRolesAsync(user);

            // 6. Return AuthResultDto
            authModel.IsAuthenticated = true;
            authModel.JWTToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            authModel.Email = user.Email!;
            authModel.Name = $"{user.FirstName} {user.LastName}";
            authModel.JWTTokenExpiresOn = jwtSecurityToken.ValidTo;
            authModel.Roles = rolesList.ToList();

            return authModel;


        }
    }
}
