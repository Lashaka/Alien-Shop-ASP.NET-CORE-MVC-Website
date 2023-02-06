using AlienShopWebsite.Models;
namespace AlienShopWebsite.Repositories
{
   public interface Irepository
    {
        IEnumerable<Alien> GetAliens();
        IEnumerable<Category> GetCategories();
        List<Alien> Top3Aliens();
        Alien GetAlienById(int id);
        void Delete(int id); 
        void AddAlien(Alien alien);
        void UpdateAlien(int id, Alien alien);
         IEnumerable<Alien> ByCategory(int categoryID);
        IEnumerable<Comment> AddComments(string comment, int id);
        IEnumerable <Comment> ShowComments(int Id);
    }
}
