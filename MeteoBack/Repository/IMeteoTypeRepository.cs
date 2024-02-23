using MeteoBack.Entities;

namespace MeteoBack.Repository
{
	public interface IMeteoTypeRepository { 

		public Task<MeteoType> GetByIdAsync(int id);
		public Task<IEnumerable<MeteoType>> GetAllAsync();
		public Task InsertAsync(MeteoType meteoType);
		public Task UpdateAsync(MeteoType meteoType);
		public Task DeleteAsync(MeteoType meteoType);
		Task SaveAsync();
	}
}
