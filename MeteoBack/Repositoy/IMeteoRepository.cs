using MeteoBack.Entities;

namespace MeteoBack.Repositoy
{
	public interface IMeteoRepository { 

		public Task<Meteo> GetByIdAsync(int id);
		public Task<IEnumerable<Meteo>> GetAllAsync();
		public Task InsertAsync(Meteo meteo);
		public Task UpdateAsync(Meteo meteo);
		public Task DeleteAsync(Meteo meteo);
		Task SaveAsync();
	}
}
