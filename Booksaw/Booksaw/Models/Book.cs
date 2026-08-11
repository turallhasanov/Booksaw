namespace Booksaw.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public IEnumerable<BookImage> BookImages { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
