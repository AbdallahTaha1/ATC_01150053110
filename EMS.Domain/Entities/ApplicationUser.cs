using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EMS.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;
        [Required, MaxLength(20)]
        public string LastName { get; set; } = string.Empty;
        public ICollection<UserBookedEvent> Events { get; set; } = [];

    }
}
