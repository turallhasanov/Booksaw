namespace Booksaw.Services.Interfaces
{
    public interface ISettingService
    {
        Task<Dictionary<string, string>> GetAllUISetting();
    }
}
