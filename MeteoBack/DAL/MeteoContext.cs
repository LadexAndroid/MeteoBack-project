using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;

namespace MeteoBack.DAL
{


	public class MeteoContext : DbContext
	{
		public DbSet<Meteo> Meteos { get; set; }
		public DbSet<City> Cities { get; set; }


		public MeteoContext(DbContextOptions options) : base(options)
		{
		}

	}

	public class Meteo
	{

		[Key]
		public int Id { get; set; }

		public DateTime Date { get; set; }

		public int TemperatureC { get; set; }

		public int WindSpeed { get; set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? RainType { get; set; }

		public string? SunType { get; set; }

		public string? Summary { get; set; }

	}

	public class City
	{
		[Key]
		public int Id { get; set; } 
		public int MeteoId { get; set; }
		public List<Meteo> Meteos { get; } = new();


	}
}