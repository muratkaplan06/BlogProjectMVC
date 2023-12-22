using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [StringLength(100)]
        public string BlogTitle { get; set; }
        [StringLength(100)]
        public string BlogImage { get; set; }
        public DateTime CreatedTime { get; set; }
        public string BlogContent { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
