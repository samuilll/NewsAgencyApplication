﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using New.Models;
using NewsAgency.App.Models;
using NewsAgency.App.Models.Articles;

namespace NewsAgency.App.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
           
            List<ArticleViewModel> mostPopularArticles = this.DbContext
                .Articles
                .OrderByDescending(a => a.Likes.Value)
                .Select(a => new ArticleViewModel()
                {
                    Id=a.Id,
                    Author = new AuthorViewModel()
                    {
                         Username = a.Author.Username,
                    },
                    Title = a.Title,                  
                })
                .Take(3)
                .ToList();


            List<CategoryWithArticlesViewModel> categories = DbContext.Categories.ToList()
                .Where(c=>c.Articles.Any())
                .Select(c => new CategoryWithArticlesViewModel()
                {
                    Name = c.Name,
                    LatestArticles = c.Articles.OrderBy(a=>a.Id).
                        Skip(Math.Max(0, c.Articles.Count() - 3))
                        .Select(a=>new ArticleViewModel()
                        {
                            Id=a.Id,
                            Title = a.Title,
                            Author = new AuthorViewModel()
                            {
                                Username = a.Author.Username,
                            },
                        }).ToList()                        
                })
                .ToList();

            HomeViewModel model = new HomeViewModel()
            {
                MostPopularArticles = mostPopularArticles,
                LatestArticlesByCategories = categories
            };

            return View(model);
        }

    }
}