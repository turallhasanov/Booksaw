using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;

namespace Booksaw.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAllUIAsync();
            return View(result);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(CategoryCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            await _categoryService.CreateAsync(request);
            return RedirectToAction(nameof(Index));
        }
    }
}
