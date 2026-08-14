using Booksaw.Data;
using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Book;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        public BookService(AppDbContext appDbContext)
        {
            _context = appDbContext;   
        }

        public async Task<IEnumerable<BookUIVM>> GetAllUIAsync()
        {
            IEnumerable<BookUIVM> books = await _context.Books.Include(n => n.BookImages).Select(m => new BookUIVM()
            {
                Id = m.Id,
                Description = m.Description,
                Name = m.Name,
                Price = m.Price,
                MainImage = m.BookImages.FirstOrDefault(m => m.IsMain).Image,
                IsFeatured = m.IsFeatured,
                IsOffer = m.IsOffer,
                BestSelling = m.BestSelling

            }).ToListAsync();

            return books;
        }


    }
}
