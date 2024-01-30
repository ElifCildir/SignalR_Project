using Microsoft.AspNetCore.Mvc;

namespace WEBUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
