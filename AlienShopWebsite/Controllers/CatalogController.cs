﻿using Microsoft.AspNetCore.Mvc;

namespace AlienShopWebsite.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
