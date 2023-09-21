using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using EcoPower_Logistics.Data;
using static EcoPower_Logistics.Reopository.ProductRepository;

namespace EcoPower_Logistics.Reopository
{
    public class ProductRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // TO DO: Add ‘Get By Id’ for Products
        public Product GetById(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product == null) {
                throw new InvalidOperationException("product not found");
            }

            return product;
        }

        // TO DO: Add ‘Create’ for Products
        public void Create(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // TO DO: Add ‘Edit’ for Products
        public void Edit(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // TO DO: Add ‘Delete’ for Products
        public void Delete(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public bool Exists(int productId)
        {
            return _context.Products.Any(p => p.ProductId == productId);
        }
    }

}
