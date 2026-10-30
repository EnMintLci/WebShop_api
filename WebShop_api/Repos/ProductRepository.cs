using Microsoft.EntityFrameworkCore;
using System;
using WebShop_api.Data;
using WebShop_api.Models;

namespace WebShop_api.Repos
{
    public class ProductRepository : IProductRepository
    {
        private Db_Context _context;

        public ProductRepository(Db_Context context)
        {
            _context = context;
        }
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProduct(id);
            if(product!=null)
            {_context.Products.Remove(product);
                _context.SaveChanges();
            }
            else throw new Exception("Product with this id not found");
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public void UpdateProduct(int id, Product product)
        {
            var p = GetProduct(id);
            if (p != null)
            {
                p.Name = product.Name;
                p.Price = product.Price;
                _context.SaveChanges();
            }
            else throw new Exception("Product with this id not found");
        }
    }
}
