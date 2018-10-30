using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;


namespace New.Models
{
    public class Category
    {
        public Category()
        {
            this.Articles = new List<Article>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}