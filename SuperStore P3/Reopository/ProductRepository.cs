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

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }

}
