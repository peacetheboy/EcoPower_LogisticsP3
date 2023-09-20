using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using EcoPower_Logistics.Data;
using static EcoPower_Logistics.Reopository. ProductRepository;

namespace EcoPower_Logistics.Reopository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SuperStoreContext context) : base(context)
        {
        }

        public Product GetMostRecentProduct()
        {
            return _context.Products.OrderByDescending(Product => Product.ProductId).FirstOrDefault();
        }
    }
}
