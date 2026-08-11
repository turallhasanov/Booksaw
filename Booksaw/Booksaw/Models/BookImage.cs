namespace Booksaw.Models
{
    public class BookImage : BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
