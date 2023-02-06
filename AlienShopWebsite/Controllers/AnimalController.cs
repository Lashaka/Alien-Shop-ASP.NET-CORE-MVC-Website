using Microsoft.AspNetCore.Mvc;

namespace AlienShopWebsite.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
