using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace green_space.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Color
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Code { get; set; }

        public ICollection<PlantColor> PlantColors { get; set; }
    }
}

