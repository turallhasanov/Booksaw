using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Booksaw.Models
{
    public class Quotation : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
