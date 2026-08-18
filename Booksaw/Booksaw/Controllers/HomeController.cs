using Booksaw.Data;
using Booksaw.Models;
using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Book;
using Booksaw.ViewModels.Brand;
using Booksaw.ViewModels.Categories;
using Booksaw.ViewModels.Home;
using Booksaw.ViewModels.Quotation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IBookService _bookService;
        private readonly IQuotationService _quotationService;
        private readonly ICategoryService _categoryService;
        public HomeController(IBrandService brandService, 
                                IBookService bookService, 
                                IQuotationService quotationService,
                                ICategoryService categoryService)
        {
            _brandService = brandService;
            _bookService = bookService;
            _quotationService = quotationService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<BrandUIVM> brands = await _brandService.GetAllUIAsync();
            IEnumerable<BookUIVM> books = await _bookService.GetAllUIAsync();
            QuotationUIVM quotations = await _quotationService.GetUIAsync();
            IEnumerable<CategoryUIVM> categories = await _categoryService.GetAllUIAsync();


            HomeVM homeVM = new HomeVM()
            {
                Brands = brands,
                Books = books,
                Quotations = quotations,
                Categories = categories
            };
            return View(homeVM);

        }
    }
}

