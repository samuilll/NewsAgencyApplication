using System;
using System.Data.Entity;
using System.Linq.Expressions;
using Microsoft.AspNet.Identity.EntityFramework;
using New.Models;

namespace News.Repository
{
    public class NewsDbContext:IdentityDbContext<User>
    {

        public IDbSet<Article> Articles { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Like> Likes { get; set; }


        public static NewsDbContext Create()
        {
            return new NewsDbContext();
        }

        public NewsDbContext()
            : base(Constants.ConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsDbContext, Configuration>());
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Like>().HasKey(l => new {l.ArticleId, l.Value});

            base.OnModelCreating(builder);
        }
    }
}
