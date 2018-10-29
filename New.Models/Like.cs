namespace New.Models
{
    public class Like
    {
        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public string Value { get; set; }
    }
}