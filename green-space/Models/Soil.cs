using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace green_space.Models
{
	[Index(nameof(Requirement), IsUnique = true)]
	public class Soil
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Requirement { get; set; }

		public string? Description { get; set; }
	}
}

