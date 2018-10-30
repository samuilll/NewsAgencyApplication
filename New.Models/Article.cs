using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace New.Models
{
    public class Article
    {
        public Article()
        {
            Likes = new List<Like>();
        }

        [Key] public int Id { get; set; }

        [Required] [MaxLength(200)] public string Title { get; set; }

        [Required] [MaxLength(5000)] public string Content { get; set; }

        public int CategoryId { get; set; }

        [Required] public virtual Category Category { get; set; }

        public int AuthorId { get; set; }

        [Required] public virtual Author Author { get; set; }

        [Required] public DateTime CreatedOn { get; set; }

        public virtual IList<Like> Likes { get; set; }
    }
}