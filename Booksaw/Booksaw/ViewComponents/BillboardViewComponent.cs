using Booksaw.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Booksaw.ViewComponents
{
    public class BillboardViewComponent : ViewComponent
    {
        private readonly IBookService _bookService;
        public BillboardViewComponent(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var books = await _bookService.GetAllUIAsync();
            return View(books);
        }
    }
}
