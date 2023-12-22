using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(30)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
