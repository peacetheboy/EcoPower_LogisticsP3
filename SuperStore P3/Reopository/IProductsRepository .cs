using System;
using System.Collections.Generic;

namespace EcoPower_Logistics.Reopository
{
    public interface IProductsRepository
    {
        // Define methods for product-related data access here

        List<Product> GetAllProducts();
        Product GetProductById(int productId);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }

   
}

