using Booksaw.ViewModels.Quotation;

namespace Booksaw.Services.Interfaces
{
    public interface IQuotationService
    {
        Task<QuotationUIVM> GetUIAsync();
    }
}
