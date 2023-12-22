using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SubscribeMail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress, MaxLength(500)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}
