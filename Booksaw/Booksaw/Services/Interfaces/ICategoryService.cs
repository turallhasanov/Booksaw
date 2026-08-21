using Booksaw.ViewModels.Categories;

namespace Booksaw.Services.Interfaces
{
    public interface ICategoryService
    {
         Task<IEnumerable<CategoryUIVM>> GetAllUIAsync();
         Task CreateAsync(CategoryCreateVM category);

        Task<CategoryDetailVM> GetDetailAsync(int id);
        Task DeleteAsync(int id);
        Task<bool> ExistAsync(string name);
    }
}
