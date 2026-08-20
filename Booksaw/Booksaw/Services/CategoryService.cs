using Booksaw.Data;
using Booksaw.Models;
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

        public async Task CreateAsync(CategoryCreateVM category)
        {
            await _appDbContext.AddAsync(new Category { 
            Name = category.Name,
            });
            await _appDbContext.SaveChangesAsync();
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
