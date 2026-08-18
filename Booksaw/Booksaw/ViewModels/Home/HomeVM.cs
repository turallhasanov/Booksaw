using Booksaw.Models;
using Booksaw.ViewModels.Book;
using Booksaw.ViewModels.Brand;
using Booksaw.ViewModels.Categories;
using Booksaw.ViewModels.Quotation;

namespace Booksaw.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<BrandUIVM> Brands { get; set; }
        public IEnumerable<BookUIVM> Books { get; set; }
        public IEnumerable<BookImage> BookImages { get; set; }
        public QuotationUIVM Quotations { get; set; }
        public IEnumerable<CategoryUIVM> Categories { get; set; }
    }
}
