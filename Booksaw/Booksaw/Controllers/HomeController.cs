using Booksaw.Data;
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
            var result = await _context.Brands.ToListAsync();
            return View(result);
        }
    }
}
