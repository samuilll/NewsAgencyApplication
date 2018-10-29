using New.Models;
using NewsAgency.App.Models.Articles;
using NewsAgency.App.Models.Categories;
using NewsAgency.App.Utilities;
using NewsAgency.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using NewsAgency.App.Models;

namespace NewsAgency.App.Controllers
{
    [Authorize]
    public class CategoryController : BaseController
    {
        private const int PerPageItems = 5;

        private IArticleService articleService;
        private ICategoryService categoryService;

        public CategoryController(IArticleService articleService, ICategoryService categoryService)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
        }


        public ActionResult All(int page = 1,string order = "default")
        {
            AllCategoriesViewModel model = new AllCategoriesViewModel()
            {
                Categories = this.categoryService.GetAllByCriteria(order)
                    .Skip((page - 1) * PerPageItems)
                    .Take(PerPageItems)
                    .Select(c => new CategoryViewModel()
                    {
                        Id = c.Id,
                        Name = c.Name,
                        NumberOfArticles = c.Articles.Count()
                    })
                    .ToList(),
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = PerPageItems,
                    TotalItems = this.categoryService.GetCount()
                }
            };

            this.ViewBag.Order = order;

            return View(model);
        }


        public ActionResult Edit(int id)
        {
            Category category = this.categoryService.GetById(id);

            if (category == null)
            {
                this.TempData["error"] = ErrorMessages.NoSuchCategory;

                return View("All");
            }

            CategoryEditViewModel model = new CategoryEditViewModel()
            {
                Id = category.Id,
                Name = category.Name
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(CategoryEditViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View();
            }

            this.categoryService.Edit(model.Id, model.Name);

            this.TempData["success"] = SuccessMessages.CategoryEditSuccess;

            return RedirectToAction("All");
        }

        public ActionResult Delete(int id = 0, string ensure = null)
        {
            if (ensure == null)
            {
                Category category = this.categoryService.GetById(id);

                CategoryDeleteViewModel model = new CategoryDeleteViewModel()
                {
                    Name=category.Name
                };

                return View(model);
            }

            this.categoryService.Delete(id);

            this.TempData["success"] = SuccessMessages.CategoryEditSuccess;

            return RedirectToAction("All");
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryCreateViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View(model);
            }

            Category category = new Category()
            {
                Name = model.Name
            };

            if (this.categoryService.Exist(category.Name))
            {
                this.TempData["error"] = ErrorMessages.CategoryAlreadyExist;

                return View();
            }
            this.DbContext.Categories.Add(category);

            this.DbContext.SaveChanges();

            this.TempData["success"] = SuccessMessages.CategoryCreatedSuccess;

            return RedirectToAction("All");
        }
    }
}