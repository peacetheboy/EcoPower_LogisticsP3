using Data;
using EcoPower_Logistics.Data;
using Models;
using static EcoPower_Logistics.Reopository.CustomersRepository;

namespace EcoPower_Logistics.Reopository
{
    public class CustomersRepository : GenericRepository<Product>, ICustomerRepository
    {
        public CustomersRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentCustomer()
        {
            return _context.Customers.OrderByDescending(Customer => Customer.CustomerId).FirstOrDefault();
        }
    }
}