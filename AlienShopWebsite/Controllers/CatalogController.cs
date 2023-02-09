using AlienShopWebsite.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AlienShopWebsite.Controllers
{
    public class CatalogController : Controller
    {
        private Irepository irepository;

        public CatalogController(Irepository _iripository)
        {
            this.irepository = _iripository;
        }
        public IActionResult Index(int Id)
        {
            ViewBag.Categories = irepository.GetCategories();
            if (Id == 0)
                return View(irepository.GetAliens());
            else
            {
                return View(irepository.ByCategory(Id));
            }
        }
        public IActionResult Details(int Id)
        {

            var comments = irepository.ShowComments(Id);
            var aliens = irepository.GetAlienById(Id);
            return View(aliens);
        }
        [HttpPost]
        public IActionResult AddComment(int AlienId, string comment)
        {
            if (comment.IsNullOrEmpty() || comment.Length > 100)
            {

                return RedirectToAction("Details", "Catalog", new { id = AlienId });
            }
            else
            {
                var aliens = irepository.GetAlienById(AlienId);
                irepository.AddComments(comment, AlienId);
            }
            return RedirectToAction("Details", "Catalog", new { id = AlienId });
        }
    }
}
