using Booksaw.Data;
using Booksaw.Models;
using Booksaw.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Brand> brands = await _context.Brands.ToListAsync();
            IEnumerable<Book> books = await _context.Books.Include(m=>m.BookImages).ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();

            HomeVM homeVM = new HomeVM()
            {
                Brands = brands,
                Books = books,
                Categories = categories
                
            };
            return View(homeVM);
        }
    }
}
