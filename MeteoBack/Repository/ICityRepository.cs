using MeteoBack.Entities;

namespace MeteoBack.Repository
{
	public interface ICityRepository { 

		public Task<City> GetByIdAsync(int id);
		public Task<IEnumerable<City>> GetAllAsync();
		public Task InsertAsync(City city);
		public Task UpdateAsync(City city);
		public Task DeleteAsync(City city);
		Task SaveAsync();
	}
}
