using Booksaw.ViewModels.Book;

namespace Booksaw.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookUIVM>> GetAllUIAsync();

    }
}
