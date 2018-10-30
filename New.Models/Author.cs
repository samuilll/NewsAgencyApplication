using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace New.Models
{
    public class Author
    {
        public Author()
        {
            this.Articles = new List<Article>();
        }

        public int Id { get; set; }

        [DisplayName("Author")]
        [MaxLength(200)]
        public string Username { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}