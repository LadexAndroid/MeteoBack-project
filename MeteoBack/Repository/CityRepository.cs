using MeteoBack.DAL;
using MeteoBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeteoBack.Repository
{
	public class CityRepository : ICityRepository
	{
		private readonly MeteoContext _dbContext;

		public CityRepository(MeteoContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task InsertAsync(City city)
		{
			await _dbContext.Cities.AddAsync(city);
		}

		public async Task DeleteAsync(City city)
		{
			_dbContext.Cities.Remove(city);
		}

		public async Task<IEnumerable<City>> GetAllAsync()
		{
			return await _dbContext.Cities.Include(e => e.Meteos).ToListAsync();
		}

		public async Task<City> GetByIdAsync(int id)
		{
			var city = await _dbContext.Cities
			   .Include(e => e.Meteos)
			   .FirstOrDefaultAsync(m => m.Id == id);
			return city;
		}

		public async Task UpdateAsync(City city)
		{
			_dbContext.Cities.Update(city);
		}

		public async Task SaveAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
	
}
