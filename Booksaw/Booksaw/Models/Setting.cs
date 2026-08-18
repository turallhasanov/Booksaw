using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Booksaw.Models
{
    public class Setting : BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
