﻿using Microsoft.AspNetCore.Mvc;

namespace WEBUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookaTableComponentPartial: ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();

        }

    }
}
