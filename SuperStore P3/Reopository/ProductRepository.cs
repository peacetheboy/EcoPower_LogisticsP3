using System;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductDescription { get; set; } = null!;
        public string ProductName { get; set; } = null!;
    }

    public class ProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product GetProductById(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                throw new InvalidOperationException("Product not found");
            }
            return product;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductDescription = product.ProductDescription;
                existingProduct.ProductName = product.ProductName;
            }
        }

        public void DeleteProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}