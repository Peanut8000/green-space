namespace green_space.Models
{
	public class PlantProduce
	{
		public int PlantId { get; set; }
		public Plant Plant { get; set; }

		public int ProduceId { get; set; }
		public Produce Produce { get; set; }
	}
}
