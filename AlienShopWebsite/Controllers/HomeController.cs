using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using AlienShopWebsite.Repositories;

namespace AlienShopWebsite.Controllers
{
    public class HomeController : Controller
    {
        private Irepository irepository;
        public HomeController(Irepository iripository)
        {
            this.irepository = iripository;
        }

        public IActionResult Index()
        {
            return View(irepository.Top3Aliens());
        }

    }
}