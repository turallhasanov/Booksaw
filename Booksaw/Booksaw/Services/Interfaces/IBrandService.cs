using Booksaw.ViewModels.Brand;

namespace Booksaw.Services.Interfaces
{
    public interface IBrandService
    {
         Task<IEnumerable<BrandUIVM>> GetAllUIAsync();

    }
}
