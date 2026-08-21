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

        public async Task DeleteAsync(int id)
        {
            var category = await _appDbContext.Categories.FindAsync(id);
            if (category is null)
            {
                Console.WriteLine("Category Not Found");
            }
            _appDbContext.Categories.Remove(category);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistAsync(string name)
        {
            return await _appDbContext.Categories.AnyAsync(m => m.Name.Equals(name.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<CategoryUIVM>> GetAllUIAsync()
        {
            return await _appDbContext.Categories.Select(m => new CategoryUIVM
            {
                Id = m.Id,
                Name = m.Name,

            }).ToListAsync();
        }

        public async Task<CategoryDetailVM> GetDetailAsync(int id)
        {
            var category = await _appDbContext.Categories.FindAsync(id);
            if (category is null)
            {
                Console.WriteLine("Category Not Found");
            }

            return new CategoryDetailVM { Name = category.Name };
        }

        
    }
}
