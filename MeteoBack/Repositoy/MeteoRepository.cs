using MeteoBack.DAL;
using MeteoBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeteoBack.Repositoy
{
	public class MeteoRepository : IMeteoRepository
	{
		private readonly MeteoContext _dbContext;

		public MeteoRepository(MeteoContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task InsertAsync(Meteo meteo)
		{
			await _dbContext.Meteos.AddAsync(meteo);
		}

		public async Task DeleteAsync(Meteo meteo)
		{
			_dbContext.Meteos.Remove(meteo);
		}

		public async Task<IEnumerable<Meteo>> GetAllAsync()
		{
			return await _dbContext.Meteos.Include(e => e.Meteotypes).ToListAsync();
		}

		public async Task<Meteo> GetByIdAsync(int id)
		{
			var meteo = await _dbContext.Meteos
			   .Include(e => e.Meteotypes)
			   .FirstOrDefaultAsync(m => m.Id == id);
			return meteo;
		}

		public async Task UpdateAsync(Meteo meteo)
		{
			_dbContext.Meteos.Update(meteo);
		}

		public async Task SaveAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
	
}
