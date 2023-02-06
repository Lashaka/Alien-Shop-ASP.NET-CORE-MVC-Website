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
            var animals = irepository.GetAlienById(Id);
            return View(animals);
        }
        [HttpPost]
        public IActionResult AddComment(int AnimalId, string comment)
        {
            if (comment.IsNullOrEmpty() || comment.Length > 100)
            {

                return RedirectToAction("Details", "Catalog", new { id = AnimalId });
            }
            else
            {
                var animals = irepository.GetAlienById(AnimalId);
                irepository.AddComments(comment, AnimalId);
            }
            return RedirectToAction("Details", "Catalog", new { id = AnimalId });
        }
    }
}
