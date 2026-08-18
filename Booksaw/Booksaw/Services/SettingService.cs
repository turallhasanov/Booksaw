using Booksaw.Data;
using Booksaw.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Booksaw.Services
{
    public class SettingService : ISettingService
    {
        private readonly AppDbContext _context;
        public SettingService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<Dictionary<string, string>> GetAllUISetting()
        {
            return await _context.Settings.ToDictionaryAsync(m=>m.Key, m=>m.Value);
        }
    }
}
