using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CashDesksController : ControllerBase
	{
		private readonly ICashDeskService _cashDeskService;

		public CashDesksController(ICashDeskService cashDeskService)
		{
			this._cashDeskService = cashDeskService;
		}


		[HttpGet]

		public IActionResult TotalCashDeskAmount()
		{
			return Ok(_cashDeskService.TTotalCashDeskAmount());

		}


	}
}
