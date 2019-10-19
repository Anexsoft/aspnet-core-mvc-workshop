using Model;
using Persistence.Database;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetAllWithPosts();
    }

    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public List<Category> GetAll() 
        {
            return _context.Categories.ToList();
        }

        public List<Category> GetAllWithPosts()
        {
            return _context.Categories.Select(x => new Category { 
                CategoryId = x.CategoryId,
                Name = x.Name,
                Posts = _context.Blogs.Count(y => y.CategoryId == x.CategoryId)
            }).ToList();
        }
    }
}
