using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.LayoutComponents
{
	public class _LayoutNavBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();

		}

	}
}
