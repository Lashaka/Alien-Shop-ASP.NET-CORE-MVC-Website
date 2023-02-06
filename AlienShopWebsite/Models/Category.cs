using System.ComponentModel.DataAnnotations;

namespace AlienShopWebsite.Models
{
    public class Category
    {
        [Required]
        public int CategoryId { get; set; }

        [Display(Name = "name")]
        [Required(ErrorMessage = "please write a valid name")]
        public string Name { get; set; } = null!;
        public virtual ICollection<Alien>? Aliens { get; set; }
    }
}
