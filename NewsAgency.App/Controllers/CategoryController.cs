using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using New.Models;
using News.Repository;
using NewsAgency.App.Models;
using NewsAgency.App.Models.Categories;
using NewsAgency.App.Utilities;
using NewsAgency.Services.Contracts;

namespace NewsAgency.App.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private const int PerPageItems = 5;

        private IArticleService articleService;
        private readonly ICategoryService categoryService;
        private NewsDbContext DbContext;
        private readonly IMapper Mapper;

        public CategoryController(IArticleService articleService,
            ICategoryService categoryService, NewsDbContext dbContext, IMapper mapper)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            DbContext = dbContext;
            Mapper = mapper;
        }

        public ActionResult All(int page = 1, string order = "default")
        {
            var model = new AllCategoriesViewModel
            {
                Categories = categoryService.GetAllByCriteria(order)
                    .Skip((page - 1) * PerPageItems)
                    .Take(PerPageItems)
                    .AsQueryable()
                    .ProjectTo<CategoryViewModel>(Mapper.ConfigurationProvider)
                    .ToList(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PerPageItems,
                    TotalItems = categoryService.GetCount()
                }
            };

            ViewBag.Order = order;

            return View(model);
        }


        public ActionResult Edit(int id)
        {
            var category = categoryService.GetById(id);

            if (category == null)
            {
                TempData["error"] = ErrorMessages.NoSuchCategory;

                return View("All");
            }

            var model = Mapper.Map<CategoryEditViewModel>(category);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CategoryEditViewModel model)
        {
            if (!ModelState.IsValid) return View();

            categoryService.Edit(model.Id, model.Name);

            TempData["success"] = SuccessMessages.CategoryEditSuccess;

            return RedirectToAction("All");
        }

        public ActionResult Delete(int id = 0, string ensure = null)
        {
            if (ensure == null)
            {
                var category = categoryService.GetById(id);

                var model = Mapper.Map<CategoryDeleteViewModel>(category);

                return View(model);
            }

            categoryService.Delete(id);

            TempData["success"] = SuccessMessages.CategoryEditSuccess;

            return RedirectToAction("All");
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryCreateViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var category = new Category
            {
                Name = model.Name
            };

            if (categoryService.Exist(category.Name))
            {
                TempData["error"] = ErrorMessages.CategoryAlreadyExist;

                return View();
            }

            categoryService.SaveItem(category);

            TempData["success"] = SuccessMessages.CategoryCreatedSuccess;

            return RedirectToAction("All");
        }
    }
}