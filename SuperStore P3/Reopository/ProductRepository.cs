using Data;
using Controllers;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using Models;
using EcoPower_Logistics.Data;

namespace EcoPower_Logistics.Reopository
{
    public class ProductRepository
    {
        protected readonly SuperStoreContext _context;

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // GET BY ID: Product
        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        // CREATE: Product
        public void Create(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // EDIT: Product
        public void Edit(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // DELETE: Product by ID
        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        // CHECK IF PRODUCT EXISTS: by ID
        public bool Exists(int id)
        {
            return _context.Products.Any(p => p.Id == id);
        }
    }

}
