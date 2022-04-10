using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace green_space.Models
{
	[Index(nameof(Name), IsUnique = true)]
	public class Produce
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string? Description { get; set; }

		public ICollection<PlantProduce> PlantProduces { get; set; }
	}
}

