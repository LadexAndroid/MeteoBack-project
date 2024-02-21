using System.ComponentModel.DataAnnotations;

namespace MeteoBack.Entities
{
	public class City
	{
		[Key]
		public int Id { get; set; }
		public string? CityName { get; set; }

		public IList<Meteo> Meteos { get; } = new List<Meteo>();
	}
}
