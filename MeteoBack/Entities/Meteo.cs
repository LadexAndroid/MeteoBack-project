using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace MeteoBack.Entities
{
	public class Meteo
	{
		[Key]
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public double TemperatureC { get; set; }

		public double WindSpeed { get; set; }

		public double TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? Summary { get; set; }

		public int CityId { get; set; }

		public City City { get; set; } = null!;

		public IList<MeteoType> Meteotypes { get; } = new List<MeteoType>();
	}
}
