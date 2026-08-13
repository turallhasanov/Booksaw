using Booksaw.Data;
using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Brand;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Services
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _appDbContext;
        public BrandService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<BrandUIVM>> GetAllUIAsync()
        {
            IEnumerable<BrandUIVM> brands = await _appDbContext.Brands.Select(b => new BrandUIVM
            {
                Image = b.Image
            }).ToListAsync();   

            return brands;
         }
        
    }
}
