﻿namespace NewsAgency.App.Models.DisplayModels.Articles
{
    public class ArticleAdminViewModel
    {
        public int Id { get; set; }

        public int Likes { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public string CreatedOn { get; set; }
    }
}