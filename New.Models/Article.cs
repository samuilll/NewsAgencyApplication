using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace New.Models
{
   public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public virtual Category Category { get; set;}

        public int AuthorId { get; set; }

        [Required]
        public virtual Author Author { get; set; }

        public virtual Like Likes { get; set; }
    }
}
