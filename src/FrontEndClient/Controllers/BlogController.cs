using Microsoft.AspNetCore.Mvc;
using Model;
using Services;

namespace FrontEndClient.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;

        public BlogController(IBlogService blogService, ICategoryService categoryService) 
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }

        public IActionResult Index() 
        {
            return View(_blogService.GetAll());
        }

        public IActionResult Create() 
        {
            ViewBag.categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            _blogService.Create(blog);
            return RedirectToAction("Index");
        }
    }
}
