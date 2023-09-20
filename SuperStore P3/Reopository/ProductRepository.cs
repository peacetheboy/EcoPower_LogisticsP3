using Data;
using Controllers;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using Models;
using EcoPower_Logistics.Data;

namespace EcoPower_Logistics.Reopository
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
    }

    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; } = null!;
    }

    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }

}
