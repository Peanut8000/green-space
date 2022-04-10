using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace green_space.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Family
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}

