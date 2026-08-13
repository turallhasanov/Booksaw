using Booksaw.Data;
using Booksaw.Services.Interfaces;
using Booksaw.ViewModels.Brand;
using Booksaw.ViewModels.Quotation;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Services
{
    public class QuotationService : IQuotationService
    {
        private readonly AppDbContext _appDbContext;
        public QuotationService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<QuotationUIVM> GetUIAsync()
        {
            QuotationUIVM quotations = await _appDbContext.Quotations.Select(b => new QuotationUIVM
            {
                Name = b.Name,
                Author = b.Author,
                Description = b.Description
            }).FirstOrDefaultAsync();
            return quotations;
        }
    }
}
