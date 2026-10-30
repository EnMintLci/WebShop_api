using WebShop_api.Models;

namespace WebShop_api.Repos
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetProduct(int id);
        void CreateProduct(Product product);
        void UpdateProduct(int id, Product product);
        void DeleteProduct(int id);
    }
}
