using Booksaw.Data;
using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Categories;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _appDbContext;
        public CategoryService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<CategoryUIVM>> GetAllUIAsync()
        {
            return await _appDbContext.Categories.Select(m => new CategoryUIVM
            {
                Id = m.Id,
                Name = m.Name,

            }).ToListAsync();
        }
    }
}
