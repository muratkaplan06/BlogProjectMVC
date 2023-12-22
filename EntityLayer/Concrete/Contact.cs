using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Contact
    {
       [Key]
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.", MinimumLength = 3)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.",MinimumLength = 3)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(100, ErrorMessage = "Name length can't be more than 100.",MinimumLength = 3)]
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Required")]
        [StringLength(1000, ErrorMessage = "Name length can't be more than 1000.",MinimumLength = 3)]
        [Display(Name = "Message")]
        public string Message { get; set; }

    }
}
