using AlienShopWebsite.Models;
using AlienShopWebsite.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlienShopWebsite.Controllers
{
    public class AdminController : Controller
    {
        private Irepository irepository;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _HostDataBase;

        public AdminController(Microsoft.AspNetCore.Hosting.IHostingEnvironment _HostingContext, Irepository _irepository)
        {
            this.irepository = _irepository;
            this._HostDataBase = _HostingContext;

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

        public IActionResult DeleteAlien(int Id)
        {
            irepository.Delete(Id);
            return RedirectToAction("Index", irepository.GetAliens());
        }

        [HttpGet]
        public IActionResult EditAlien(int id)
        {
            ViewBag.Categories = irepository.GetCategories();
            return View(irepository.GetAlienById(id));
        }
        [HttpPost]
        public IActionResult EditAlien(int id, Alien alien)
        {
            string UniqeFileName = null;
            if (
                ModelState.ErrorCount == 1 &&
                ModelState.GetFieldValidationState("PicturePath") == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                string UploadFolder = Path.Combine(_HostDataBase.WebRootPath, "Images");
                UniqeFileName = Guid.NewGuid().ToString() + "_" + alien.File!.FileName;
                string FilePath = Path.Combine(UploadFolder, UniqeFileName);
                alien.File.CopyTo(new FileStream(FilePath, FileMode.Create));
            }
            Alien NewAlien = new Alien
            {
                Name = alien.Name,
                Age = alien.Age,
                CategoryId = alien.CategoryId,
                Descripition = alien.Descripition,
                PicturePath = "Images\\" + UniqeFileName
            };

            irepository.UpdateAlien(id, NewAlien);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AddAlien()
        {
            ViewBag.Categories = irepository.GetCategories();
            return View(new Alien());
        }
        [HttpPost]
        public IActionResult AddAlien(Alien alien)
        {
            string UniqeFileName = null;

            if (
           ModelState.ErrorCount == 1 &&
           ModelState.GetFieldValidationState("PicturePath") == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                string UploadFolder = Path.Combine(_HostDataBase.WebRootPath, "Images");
                if (!Directory.Exists(UploadFolder))
                {
                    Directory.CreateDirectory(UploadFolder);
                }
                UniqeFileName = Guid.NewGuid().ToString() + "_" + alien.File!.FileName;
                string FilePath = Path.Combine(UploadFolder, UniqeFileName);
                alien.File.CopyTo(new FileStream(FilePath, FileMode.Create));
            }

            Alien NewAlien = new Alien
            {
                Name = alien.Name,
                Age = alien.Age,
                CategoryId = alien.CategoryId,
                Descripition = alien.Descripition,
                PicturePath = "Images\\" + UniqeFileName
            };
            irepository.AddAlien(NewAlien);
            return RedirectToAction("Index", "Catalog");
        }
    }
}
