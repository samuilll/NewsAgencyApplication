using System.Collections.Generic;

namespace New.Models
{
    public class Author
    {
        public Author()
        {
            this.Articles = new List<Article>();
        }
        public int Id { get; set; }

        public string Username { get; set; }

        public virtual ICollection<Article> Articles{ get; set; }
    }
}