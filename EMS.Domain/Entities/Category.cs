using System.ComponentModel.DataAnnotations;

namespace EMS.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Event> Events { get; set; } = [];

    }
}
