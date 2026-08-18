namespace Booksaw.ViewModels.Book
{
    public class BookUIVM
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string MainImage { get; set; }
        public bool IsFeatured { get; set; }
        public string CategoryName { get; set; }

        public bool IsOffer { get; set; }

        public int BestSelling { get; set; }
    }
}
