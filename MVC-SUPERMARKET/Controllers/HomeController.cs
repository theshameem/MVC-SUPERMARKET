﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_SUPERMARKET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
