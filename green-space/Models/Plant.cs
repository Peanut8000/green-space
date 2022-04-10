using System.ComponentModel.DataAnnotations;

namespace green_space.Models
{
	public class Plant
	{
        [Key]
        public int Id { get; set; }

        [Display(Name = "Latin Name")]
        public string LatinName { get; set; }

        [Display(Name = "Common name")]
        public string CommonName { get; set; }

        public Family Family { get; set; }

        public Models.Type Type { get; set; }

        public string Description { get; set; }

        public ICollection<PlantColor> PlantColors { get; set; }

        public Size Size { get; set; }

        public Maintenance Maintenance { get; set; }

        public Location Location { get; set; }

        public Sun Sun { get; set; }

        public Water Water { get; set; }

        public Soil Soil { get; set; }

        public ICollection<PlantProduce> PlantProduces { get; set; }

        public Allergy Allergy { get; set; }
    }
}

