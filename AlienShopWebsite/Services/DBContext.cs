using AlienShopWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using static System.Net.WebRequestMethods;

namespace AlienShopWebsite.Services
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<Alien> Aliens { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alien>().HasData(
            new
            {
                AlienId = 1,
                Name = "Cute Alien Baby Squirrel",
                Age = 5,
                Descripition = " adorable and furry extraterrestrial creature with the appearance of a baby squirrel.",
                PicturePath = "https://i.imgur.com/u7QS7NW.jpeg",
                CategoryId = 1

            },
            new
            {
                AlienId = 2,
                Name = "Fluffy Redhand Shlomper",
                Age = 32,
                Descripition = "fluffy and friendly extraterrestrial with red hands and an adorable appearance.",
                PicturePath = "https://w0.peakpx.com/wallpaper/277/21/HD-wallpaper-cute-alien-alien-art-cute-new.jpg",
                CategoryId = 1
            },
            new
            {
                AlienId = 3,
                Name = "Yellow Fredrih (Friendly)",
                Age = 1,
                Descripition = "A cheerful and friendly yellow extraterrestrial creature with an undefined appearance.",
                PicturePath = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F6%2F2016%2F06%2Fcj7.jpg",
                CategoryId = 1
            },
            new
            {
                AlienId = 4,
                Name = "Common Cloudmeat Marsmallow",
                Age = 90,
                Descripition = "A soft, puffy, and sweet extraterrestrial creature made of cloud-like matter and shaped like a marshmallow.",
                PicturePath = "https://vignette.wikia.nocookie.net/3a87a18d-beb3-4c06-9624-9a54a49285d6/scale-to-width-down/1200",
                CategoryId = 4
            },
            new
            {
                AlienId = 5,
                Name = "DemiAdam Alien (shreker breed)",
                Age = 20,
                Descripition = "A hybrid extraterrestrial creature that combines the traits of the shreker and DemiAdam species.",
                PicturePath = "https://i5.walmartimages.com/asr/b16ea7b8-d49f-481c-8982-05b089cf7197.6e853ecbe3da28bf6752c1a445fda3ed.jpeg",
                CategoryId = 3
            },
            new
            {
                AlienId = 6,
                Name = "Sand Shlomper",
                Age = 42,
                Descripition = "A extraterrestrial creature with a shaggy, sand-like appearance and a playful personality.",
                PicturePath = "http://static.demilked.com/wp-content/uploads/2016/03/cute-fantasy-monsters-dolls-katyushka-7.jpg",
                CategoryId = 2
            },
            new
            {
                AlienId = 7,
                Name = "Jungle Yodiger",
                Age = 42,
                Descripition = "A extraterrestrial creature with the appearance of a wild jungle animal and a playful, yodeling voice.",
                PicturePath = "https://64.media.tumblr.com/b04a9600db9ff4f52adcc3e5d12a2500/tumblr_nnq1n25je41upbn1no1_640.jpg",
                CategoryId = 1
            },
            new
            {
                AlienId = 8,
                Name = "Totem Squish",
                Age = 42,
                Descripition = "A unique extraterrestrial creature resembling a totem pole with a soft and squishy appearance.",
                PicturePath = "https://img.joomcdn.net/74accb7578dc16142179f31001f4dab6b7f6ed4b_original.jpeg",
                CategoryId = 4
            },
            new
            {
                AlienId = 9,
                Name = "Sckregelephant",
                Age = 42,
                Descripition = "A extraterrestrial creature combining the features of an elephant and a creature known as the sckreger.",
                PicturePath = "https://www.zooborns.com/.a/6a010535647bf3970b0115724e3b75970b-600wi",
                CategoryId = 2
            },
            new
            {
                AlienId = 10,
                Name = "Bicycle riding Orange Cookie",
                Age = 42,
                Descripition = "A cheerful and adventurous extraterrestrial creature shaped like an orange cookie that enjoys riding a bicycle.",
                PicturePath = "https://i.imgur.com/xDexsTf.png",
                CategoryId = 3
            });
       

            modelBuilder.Entity<Category>().HasData(
            new
            {
                CategoryId = 1,
                Name = "Pocket Alien",
            },
             new
             {
                 CategoryId = 2,
                 Name = "Galactical Alien",
             },
             new
             {
                 CategoryId = 3,
                 Name = "Humanoid Alien",
             },
             new
             {
                 CategoryId = 4,
                 Name = "Energy-based Alien",
             });

            modelBuilder.Entity<Comment>().HasData(
            new
            {
                CommentId = 1,
                Descripition = "very scry animal",
                AlienId = 1
            },
            new
            {
                CommentId = 2,
                Descripition = "poisaning animal",
                AlienId = 2
            },
            new
            {
                CommentId = 3,
                Descripition = "cute animal",
                AlienId = 3
            },
            new
            {
                CommentId = 4,
                Descripition = "huge animal",
                AlienId = 4
            },
            new
            {
                CommentId = 5,
                Descripition = "cool animal",
                AlienId = 5
            },
             new
             {
                 CommentId = 6,
                 Descripition = "scary animal",
                 AlienId = 6
             },
             new
             {
                 CommentId = 7,
                 Descripition = "dangerous animal",
                 AlienId = 7
             });
        }
    }
}
