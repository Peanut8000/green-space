
namespace green_space.Models
{
	public class PlantColor
	{
		public int PlantId { get; set; }
		public Plant Plant { get; set; }

		public int ColorId { get; set; }
		public Color Color { get; set; }		
	}
}

