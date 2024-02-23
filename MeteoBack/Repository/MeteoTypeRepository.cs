using MeteoBack.DAL;
using MeteoBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeteoBack.Repository
{
	public class MeteoTypeRepository : IMeteoTypeRepository
	{
		private readonly MeteoContext _dbContext;

		public MeteoTypeRepository(MeteoContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task InsertAsync(MeteoType meteoType)
		{
			await _dbContext.MeteoTypes.AddAsync(meteoType);
		}

		public async Task DeleteAsync(MeteoType meteoType)
		{
			_dbContext.MeteoTypes.Remove(meteoType);
		}

		public async Task<IEnumerable<MeteoType>> GetAllAsync()
		{
			return await _dbContext.MeteoTypes.ToListAsync();
		}

		public async Task<MeteoType> GetByIdAsync(int id)
		{
			var meteoType = await _dbContext.MeteoTypes
			   .FirstOrDefaultAsync(m => m.Id == id);
			return meteoType;
		}

		public async Task UpdateAsync(MeteoType meteoType)
		{
			_dbContext.MeteoTypes.Update(meteoType);
		}

		public async Task SaveAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
	
}
