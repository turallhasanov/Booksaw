using Booksaw.Data;
using Booksaw.Models;
using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Book;
using Booksaw.ViewModels.Brand;
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
        public HomeController(IBrandService brandService, IBookService bookService, IQuotationService quotationService)
        {
            _brandService = brandService;
            _bookService = bookService;
            _quotationService = quotationService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<BrandUIVM> brands = await _brandService.GetAllUIAsync();
            IEnumerable<BookUIVM> books = await _bookService.GetAllUIAsync();
            QuotationUIVM quotations = await _quotationService.GetUIAsync();

            HomeVM homeVM = new HomeVM()
            {
                Brands = brands,
                Books = books,
                Quotations = quotations
            };
            return View(homeVM);

        }
    }
}

