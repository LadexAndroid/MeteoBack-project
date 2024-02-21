using System.ComponentModel.DataAnnotations;

namespace MeteoBack.Entities
{
	public class MeteoType
	{
		[Key]
		public int Id { get; set; } 
		public string? Title { get; set; }
		public int MeteoId { get; set; }

		public Meteo Meteo { get; set; } = null!;

	}
}
