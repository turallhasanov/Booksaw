using Booksaw.Models;

namespace Booksaw.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<BookImage> BookImages { get; set; }
    }
}
