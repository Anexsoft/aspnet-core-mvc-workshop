using Microsoft.EntityFrameworkCore;
using Model;
using Persistence.Database;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public interface IBlogService 
    {
        List<Blog> GetAll();
        void Create(Blog blog);
    }

    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext _context;

        public BlogService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public List<Blog> GetAll() 
        {
            return _context.Blogs
                           .Include(x => x.Category)
                           .ToList();
        }

        public void Create(Blog blog)
        {
            _context.Add(blog);
            _context.SaveChanges();
        }
    }
}
