namespace WebShop_api.Models
{
    public class ProductVM
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }

        public Sex Sex { get; set; }

        public string? ImageUrls { get; set; }

        public Dictionary<Size, int> Stock { get; set; } = new();
    }

}
