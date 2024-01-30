using Microsoft.AspNetCore.Mvc;

namespace WEBUI.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
             return View();
        }


    }
}
