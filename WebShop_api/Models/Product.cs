namespace WebShop_api.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }

        public Sex Sex { get; set; }

        public string? ImageUrls { get; set; }

        public ICollection<ProductStock> Stocks { get; set; } = new List<ProductStock>();
        public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public string? Description { get; set; }

    }

    public enum Size
    {
        XS, S, M, L, XL, XXL
    }
    public enum Sex
    {
        Male,
        Female,
        Unisex
    }
}
