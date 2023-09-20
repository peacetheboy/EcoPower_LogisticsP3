using Data;
using EcoPower_Logistics.Data;
using Models;
using static EcoPower_Logistics.Reopository.CustomersRepository;

namespace EcoPower_Logistics.Reopository
{
    public class CustomersRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        // GET ALL: Customers
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }
}