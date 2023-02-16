using AlienShopWebsite.Models;
using Microsoft.EntityFrameworkCore;
using AlienShopWebsite.Services;
using System.Xml.Linq;

namespace AlienShopWebsite.Repositories
{
    public class AlienRepo : IalienRepo
    {
        private readonly DBContext dBContext;

        public AlienRepo(DBContext _dbContext)
        {
            dBContext = _dbContext;
        }
        public IEnumerable<Alien> GetAliens()
        {
            return dBContext.Aliens;
        }
        public List<Alien> Top3Aliens()
        {
            return dBContext.Aliens.Include(c => c.Comments).OrderByDescending(c => c.Comments!.Count).Take(3).ToList();
        }
        public Alien GetAlienById(int id)
        {
            if (dBContext.Aliens.Any(a => a.AlienId == id))
            {
                return dBContext.Aliens.First(a => a.AlienId == id);
            }
            else
            {
                return null;
            }
        }
        public void Delete(int id)
        {
            var Alien= dBContext.Aliens.Single(Alien => Alien.AlienId == id);
            dBContext.Aliens.Remove(Alien);
            dBContext.SaveChanges();
        }
        public void AddAlien(Alien alien)
        {
            try
            {
                dBContext.Add(alien);
                dBContext.SaveChanges();
            }
            catch
            {
            }
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
            alienInDb.CategoryId = alien.CategoryId;
            alienInDb.Comments = alien.Comments;
            alienInDb.PicturePath = alien.PicturePath;
            alienInDb.Descripition = alien.Descripition;
            dBContext.SaveChanges();
        }
        public IEnumerable<Alien> ByCategory(int categoryID)
        {
            return dBContext.Categories.Find(categoryID)!.Aliens!;
        }

        public IEnumerable<Comment> AddComments(string comment, int id)
        {
            var alien = dBContext.Aliens.FirstOrDefault(a => a.AlienId == id);
            if (alien == null)
            {
                throw new ArgumentException("No Alien with the specified id was found.");
            }

            Comment _comment = new Comment
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
            return Alien?.Comments!; 
        }
    }
}

