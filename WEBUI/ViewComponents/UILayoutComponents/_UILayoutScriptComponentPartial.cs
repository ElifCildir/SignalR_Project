﻿using Microsoft.AspNetCore.Mvc;

namespace WEBUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }

    }
}