using AlienShopWebsite.Models;
using Microsoft.EntityFrameworkCore;
using AlienShopWebsite.Services;
using System.Xml.Linq;

namespace AlienShopWebsite.Repositories
{
    public class Repository : Irepository
    {
        private readonly DBContext dBContext;

        public Repository(DBContext _dbContext)
        {
            dBContext = _dbContext;
        }
        public IEnumerable<Alien> GetAliens()
        {
            return dBContext.Aliens;
        }
        public List<Alien> Top2Aliens()
        {
            return dBContext.Aliens.Include(c => c.Comments).OrderByDescending(c => c.Comments!.Count).Take(2).ToList();
        }
        public Alien GetAlienById(int id) => dBContext.Aliens.First(a => a.AlienId == id);
        public void Delete(int id)
        {
            var Alien= dBContext.Aliens.Single(Alien => Alien.AlienId == id);
            dBContext.Aliens.Remove(Alien);
            dBContext.SaveChanges();
        }
        public void AddAlien(Alien alien)
        {
           dBContext.Add(alien);
           dBContext.SaveChanges();
        }
        public IEnumerable<Category> GetCategories()
        {
            return dBContext.Categories;
        }
        public void UpdateAlien(int id, Alien alien)
        {
            var alienInDb = dBContext.Aliens!.Single(m => m.AlienId == id);
            alienInDb.Name = alien.Name;
            alienInDb.Age = alien.Age;
            alienInDb.Category = alien.Category;
            alienInDb.Comments = alien.Comments;
            alienInDb.PicturePath = alien.PicturePath;
            alienInDb.Descripition = alien.Descripition;
            dBContext.SaveChanges();
        }
        public IEnumerable<Alien> ByCategory(int categoryID)
        {
            return dBContext.Categories.Find(categoryID)!.Aliens!;
        }

        public IEnumerable<Comment> AddComments( string comment, int id)
        {
            Comment _comment = new()
            {
                Descripition = comment,
                AlienId = id
            };
            dBContext.Add(_comment);
            dBContext.SaveChanges();
            return dBContext.Comments;
        }
        public IEnumerable <Comment> ShowComments(int Id)
        {
            var Alien = dBContext.Aliens!.Find(Id);
            return Alien.Comments!; 
        }
    }
}

