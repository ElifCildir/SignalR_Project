using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebUI.Dtos.CategoryDtos;
using System.Text;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

		public CategoryController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<ActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7006/api/Category");
		  
            if(responseMessage.IsSuccessStatusCode) {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
				return View(values);
			}

			return View();
		}


		public IActionResult CreateCategory()
		{

			return View();
		}

		[HttpPost]
		public async Task <IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)

		{
			createCategoryDto.Status = true;
			var client = _httpClientFactory.CreateClient();
			var jsonData=JsonConvert.SerializeObject(createCategoryDto);
			StringContent stringContent = new StringContent(jsonData,Encoding.UTF8, "application/json");

			var responseMessage = await client.PostAsync("https://localhost:7006/api/Category", stringContent);
			if(responseMessage.IsSuccessStatusCode) 
			{
				return RedirectToAction("Index");
			}

			return View();
		
		}


		public async Task<IActionResult> DeleteCategory(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7006/api/Category/{id}");
			if(responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}


			return View();

		}

		public async Task<IActionResult> UpdateCategory(int id)
		{
			var client= _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7006/api/Category/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{

				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values=JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);

				return View(values);

			}

			return View();	

		}

		[HttpPost]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData=JsonConvert.SerializeObject(updateCategoryDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7006/api/Category/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();

		}


	}
}
