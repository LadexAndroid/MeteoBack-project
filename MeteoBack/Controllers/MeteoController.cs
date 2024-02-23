using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeteoBack.Repository;
using MeteoBack.DAL;

namespace MeteoBack.Controllers
{
	[ApiController]
	[Route("")]
	public class MeteoController : ControllerBase
	{
		private readonly MeteoContext _context;

		private readonly IMeteoRepository _meteoRepository;
		public MeteoController(IMeteoRepository meteoRepository, MeteoContext context)
		{
			_meteoRepository = meteoRepository;
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var meteos = await _meteoRepository.GetAllAsync();
			return Ok("Index");
		}
	}
}
 