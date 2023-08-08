namespace MvcEticaret.Models
{
    public class ProductsItem
    {
        public string Title { get; set; }
        public int StartCount { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSale { get; set; }
    }
}
