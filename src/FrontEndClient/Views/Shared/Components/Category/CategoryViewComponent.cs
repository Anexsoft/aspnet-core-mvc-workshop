using Microsoft.AspNetCore.Mvc;
using Services;

namespace FrontEndClient.Views.Shared.Components.CategoryViewComponent
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public CategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_categoryService.GetAllWithPosts());
        }
    }
}
