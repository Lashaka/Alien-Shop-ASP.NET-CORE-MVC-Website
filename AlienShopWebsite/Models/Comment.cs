using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlienShopWebsite.Models
{
    public class Comment
    {
        [Required]
        public int? CommentId { get; set; }
        [Display(Name = "comment")]
        [DataType(DataType.MultilineText)]
        [Range(1, 100)]
        [Required(ErrorMessage = "please write a valid comment")]
        public string? Descripition { get; set; }
        [ForeignKey("AlienId")]
        public int AlienId { get; set; }

        public virtual Alien Alien { get; set; } = null!;
    }
}
