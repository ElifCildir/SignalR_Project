﻿using Microsoft.AspNetCore.Mvc;

namespace WEBUI.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }

    }
}
