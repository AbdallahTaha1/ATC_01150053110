namespace EMS.Application.Features.Account.Commands
{
    public class AuthResultDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> Roles { get; set; } = [];
        public string JWTToken { get; set; } = string.Empty;
        public DateTime JWTTokenExpiresOn { get; set; }

        public string Message { get; set; } = string.Empty;
        public bool IsAuthenticated { get; set; }
    }
}
