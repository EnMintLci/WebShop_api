namespace WebShop_api.Models
{

    public class ProductStock
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public Size Size { get; set; }

        public int Quantity { get; set; }
    }


}


