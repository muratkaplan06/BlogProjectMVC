using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
      
        [Required(ErrorMessage = "Yorum alanı boş bırakılamaz.")]
        [StringLength(400, MinimumLength = 4, ErrorMessage = "Yorum 4 ile 400 karakter arasında olmalıdır.")]
        public string CommentText { get; set; }
        public string UserImage { get; set; }
        public DateTime CommentTime { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
