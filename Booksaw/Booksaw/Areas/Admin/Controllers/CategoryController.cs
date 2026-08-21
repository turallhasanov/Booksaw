using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(CategoryCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            await _categoryService.CreateAsync(request);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]

        public async Task<IActionResult> Detail(int?
            id)
        {
            try
            {
                if (id is null) return BadRequest();

                var category = await _categoryService.GetDetailAsync((int)id);
                return View(category);
            }
            catch (Exception ex)
            {

                return NotFound();
            }
        }
            [HttpPost]
            public async Task<IActionResult> Delete(int id)
            {
            try
            {
                await _categoryService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                throw;
            }
                
            }
        
    }
}
