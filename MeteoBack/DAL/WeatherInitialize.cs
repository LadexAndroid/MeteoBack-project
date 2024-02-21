//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Microsoft.EntityFrameworkCore;
//using System.Diagnostics;

//namespace MeteoBack.DAL
//{
//	public class WeatherInitialize : Microsoft.EntityFrameworkCore.cre
//	{
//		protected override void Seed(MeteoContext context)
//		{
//			var weathers = new List<MeteoModel>
//			{
//			new MeteoModel{City="Paris",Date=DateTime.Parse("14/02/2024"),TemperatureC=13,WindSpeed=22,SunType="Chilly"},
//			new MeteoModel{City="Real Sociedad",Date=DateTime.Parse("14/02/2024"),TemperatureC=18,WindSpeed=40,SunType="Warm"}
//			};

//			weathers.ForEach(w => context.WeatherForecast.Add(w));
//			context.SaveChanges();

//		}
//	}
//}