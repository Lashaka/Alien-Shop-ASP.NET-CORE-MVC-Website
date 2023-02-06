using Microsoft.AspNetCore.Mvc;

namespace AlienShopWebsite.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
