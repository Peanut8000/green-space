using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace green_space.Models
{
	[Index(nameof(Amount), IsUnique = true)]
	public class Maintenance
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Amount { get; set; }

		public string? Description { get; set; }
	}
}
