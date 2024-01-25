using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RestTablesController : ControllerBase
	{
		private readonly IRestTableService _restTableService;

		public RestTablesController(IRestTableService restTableService)
		{
			_restTableService = restTableService;
		}

		[HttpGet("RestTableCount")]
		public IActionResult RestTableCount() 
		{
			return Ok(_restTableService.TRestTableCount());	
		   
		}


	}
}
