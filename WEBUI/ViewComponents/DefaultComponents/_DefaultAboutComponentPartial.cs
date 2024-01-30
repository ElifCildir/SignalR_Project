using Microsoft.AspNetCore.Mvc;

namespace WEBUI.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }


    }
}
