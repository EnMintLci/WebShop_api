namespace WebShop_api.Models
{
    public class ProductImage
    {

        public int Id { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        //public int OrderIndex { get; set; }
        public ProductImage(string imageUrl)
        {
            ImageUrl = imageUrl;

        }

    }

}
