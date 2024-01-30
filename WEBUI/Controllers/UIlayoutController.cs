using Microsoft.AspNetCore.Mvc;

namespace WEBUI.Controllers
{
    public class UIlayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
