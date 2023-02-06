using AlienShopWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

namespace AlienShopWebsite.Services
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<Alien> Aliens{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var PictureName = new string[]
        {
        "https://images.foxtv.com/static.fox10phoenix.com/www.fox10phoenix.com/content/uploads/2021/07/764/432/MyLove-the-snake-crop-3-Courtesy-of-Jay-Brewer.jpg?ve=1&tl=1",
        "https://a-z-animals.com/media/2018/09/Monitor-lizard-header.jpg",
        "https://www.wilderness.org.au/images/uploads/2ACH01R-1-Alamy-sugar-glider-CROP.jpg",
        "https://i.natgeofe.com/n/e6cb0ee4-77c5-4181-bf6a-b79a28237e6c/gray-whale_4x3.jpg",
        "https://www.marylandzoo.org/wp-content/uploads/2017/10/okapi_web-1024x683.jpg",
        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1VbQTnR9TENocPXysSiKC4ugrxc74MfRU-Q&usqp=CAU",
        "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTMkO_StLYxmXywiSm67_s8ApeXx_JtqFb_ng&usqp=CAU"
        };
            modelBuilder.Entity<Alien>().HasData(
            new
            {
                AlienId = 1,
                Name = "Python",
                Age = 5,
                Descripition = "Python is a genus of constricting snakes in the Pythonidae family native to the tropics and subtropics of the Eastern Hemisphere. The name Python was proposed by François Marie Daudin in 1803 for non-venomous flecked snakes. Currently, 10 python species are recognized as valid taxa.",
                PicturePath = PictureName[0],
                CategoryId = 2
                
            },
            new
            {
                AlienId = 2,
                Name = "Monitor Lizard",
                Age = 12,
                Descripition = "Monitor lizards are lizards in the genus Varanus, the only extant genus in the family Varanidae. They are native to Africa, Asia, and Oceania, and one species is also found in the Americas as an invasive species. About 80 species are recognized.\r\n\r\nMonitor lizards have long necks, powerful tails and claws, and well-developed limbs. The adult length of extant species ranges from 20 cm (7.9 in) in some species, to over 3 m (10 ft) in the case of the Komodo dragon, though the extinct varanid known as megalania (Varanus priscus) may have been capable of reaching lengths more than 7 m (23 ft). Most monitor species are terrestrial, but arboreal and semiaquatic monitors are also known. While most monitor lizards are carnivorous, eating eggs, smaller reptiles, fish, birds, insects, and small mammals, some also eat fruit and vegetation, depending on where they live.",
                PicturePath = PictureName[1],
                CategoryId = 2
            },
            new
            {
                AlienId = 3,
                Name = "sugar glider",
                Age = 2,
                Descripition = "The sugar glider (Petaurus breviceps) is a small, omnivorous, arboreal, and nocturnal gliding possum belonging to the marsupial infraclass. The common name refers to its predilection for sugary foods such as sap and nectar and its ability to glide through the air, much like a flying squirrel. They have very similar habits and appearance to the flying squirrel, despite not being closely related",
                PicturePath = PictureName[2],
                CategoryId = 1
            },
            new
            {
                AlienId = 4,
                Name = "grey whale",
                Age = 90,
                Descripition = "The gray whale (Eschrichtius robustus), also known as the grey whale, gray back whale, Pacific gray whale, Korean gray whale, or California gray whale, is a baleen whale that migrates between feeding and breeding grounds yearly. It reaches a length of 14.9 meters (49 ft), a weight of up to 41 tonnes (90,000 lb) and lives between 55 and 70 years, although one female was estimated to be 75–80 years of age. The common name of the whale comes from the gray patches and white mottling on its dark skin. Gray whales were once called devil fish because of their fighting behavior when hunted. The gray whale is the sole living species in the genus Eschrichtius.",
                PicturePath = PictureName[3],
                CategoryId = 4
            },
            new
            {
                AlienId = 5,
                Name = "Okapi",
                Age = 20,
                Descripition = "The okapi (/oʊˈkɑːpiː/; Okapia johnstoni), also known as the forest giraffe, Congolese giraffe, or zebra giraffe, is an artiodactyl mammal that is endemic to the northeast Democratic Republic of the Congo in central Africa. It is the only species in the genus Okapia. Although the okapi has striped markings reminiscent of zebras, it is most closely related to the giraffe. The okapi and the giraffe are the only living members of the family Giraffidae.\r\n\r\nThe okapi stands about 1.5 m (4 ft 11 in) tall at the shoulder and has a typical body length around 2.5 m (8 ft 2 in). Its weight ranges from 200 to 350 kg (440 to 770 lb). It has a long neck, and large, flexible ears. Its coat is a chocolate to reddish brown, much in contrast with the white horizontal stripes and rings on the legs, and white ankles. Male okapis have short, distinct horn-like protuberances on their heads called ossicones, less than 15 cm (5.9 in) in length. Females possess hair whorls, and ossicones are absent.",
                PicturePath = PictureName[4],
                CategoryId = 1
            },
            new
            {
                AlienId = 6,
                Name = "Goblin Shark",
                Age = 42,
                Descripition = "The goblin shark (Mitsukurina owstoni) is a rare species of deep-sea shark. Sometimes called a \"living fossil\", it is the only extant representative of the family Mitsukurinidae, a lineage some 125 million years old. This pink-skinned animal has a distinctive profile with an elongated, flat snout, and highly protrusible jaws containing prominent nail-like teeth. It is usually between 3 and 4 m (10 and 13 ft) long when mature, though it can grow considerably larger such as one captured in 2000 that is thought to have measured 6 m (20 ft). Goblin sharks are benthopelagic creatures that inhabit upper continental slopes, submarine canyons, and seamounts throughout the world at depths greater than 100 m (330 ft), with adults found deeper than juveniles. Some researchers believe that these sharks could also dive to depths of up to 1,300 m (4,270 ft), for short periods of time.",
                PicturePath = PictureName[5],
                CategoryId = 4
            },
            new
            {
                AlienId = 7,
                Name = "pacu fish",
                Age = 42,
                Descripition = "Pacu (Portuguese pronunciation: [paˈku]) is a common name used to refer to several species of omnivorous South American freshwater serrasalmid fish that are related to the piranha. Pacu and piranha do not have similar teeth, the main difference being jaw alignment; piranha have pointed, razor-sharp teeth in a pronounced underbite, whereas pacu have squarer, straighter teeth and a less severe underbite, or a slight overbite.[1] Pacu, unlike piranha, mainly feed on plant material and not flesh or scales.[2] Additionally, the pacu can reach much larger sizes than piranha, at up to 1.08 m (3 ft 6+1⁄2 in) in total length and 40 kg (88 lb) in weight.[3]",
                PicturePath = PictureName[6],
                CategoryId = 4
            });


            modelBuilder.Entity<Category>().HasData(
            new
            {
                CategoryId = 1,
                Name = "mamals",
            },
             new
             {
                 CategoryId = 2,
                 Name = "reptiles",
             },
             new
             {
                 CategoryId = 3,
                 Name = "avian",
             },
             new
             {
                 CategoryId = 4,
                 Name = "fish",
             });

            modelBuilder.Entity<Comment>().HasData(
            new
            {
                CommentsId = 1,
                Descripition = "very scry animal",
                AlienId = 1
            },
            new
            {
                CommentsId = 2,
                Descripition = "poisaning animal",
                AlienId = 2
            },
            new
            {
                CommentsId = 3,
                Descripition = "cute animal",
                AlienId = 3
            },
            new
            {
                CommentsId = 4,
                Descripition = "huge animal",
                AlienId = 4
            },
            new
            {
                CommentsId = 5,
                Descripition = "cool animal",
                AlienId = 5
            },
             new
             {
                 CommentsId = 6,
                 Descripition = "scary animal",
                 AlienId = 6
             },
             new
             {
                 CommentsId = 7,
                 Descripition = "dangerous animal",
                 AlienId = 7
             });
        }
    }
}
