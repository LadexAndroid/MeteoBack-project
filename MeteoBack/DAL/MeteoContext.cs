using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Hosting;
using MeteoBack.Entities;
using System.Reflection.Metadata;

namespace MeteoBack.DAL
{


	public class MeteoContext : DbContext
	{
		public DbSet<Meteo> Meteos { get; set; }
		public DbSet<MeteoType> MeteoTypes { get; set; }
		public DbSet<City> Cities { get; set; }




		public MeteoContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<City>()
				.HasMany(e => e.Meteos)
				.WithOne(e => e.City)
				.HasForeignKey(e => e.CityId)
				.IsRequired();


			modelBuilder.Entity<Meteo>()
				.HasMany(e => e.Meteotypes)
				.WithOne(e => e.Meteo)
				.HasForeignKey(e => e.MeteoId)
				.IsRequired();

		}

	}

 
}