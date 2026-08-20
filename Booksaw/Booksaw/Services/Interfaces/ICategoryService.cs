using Booksaw.ViewModels.Categories;

namespace Booksaw.Services.Interfaces
{
    public interface ICategoryService
    {
         Task<IEnumerable<CategoryUIVM>> GetAllUIAsync();
         Task CreateAsync(CategoryCreateVM category);
    }
}
