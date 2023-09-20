using Microsoft.EntityFrameworkCore;

namespace EcoPower_Logistics.Reopository
{
    public class CustomersRepository
    {
        public class Customer
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; } = null!;
            public string CustomerSurname { get; set; } = null!;
            public string CellPhone { get; set; } = null!;
            public string CustomerTitle { get; set; } = null!;
        }

        public class CustomerContext : DbContext
        {
            public DbSet<Customer> Customers { get; set; } = null!;

            public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
            {
            }
        }

        public interface ICustomerRepository
        {
            List<Customer> GetAllCustomers();
            Customer GetCustomerById(int customerId);
            void AddCustomer(Customer customer);
            void UpdateCustomer(Customer customer);
            void DeleteCustomer(int customerId);
        }

        public class CustomerRepository : ICustomerRepository
        {
            private readonly CustomerContext _context;

            public CustomerRepository(CustomerContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }

            public List<Customer> GetAllCustomers()
            {
                return _context.Customers.ToList();
            }

            public Customer GetCustomerById(int customerId)
            {
                return _context.Customers.Find(customerId);
            }

            public void AddCustomer(Customer customer)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }


            public void UpdateCustomer(Customer customer)
            {
                _context.Entry(customer).State = EntityState.Modified;
                _context.SaveChanges();
            }

            public void DeleteCustomer(int customerId)
            {
                var customer = _context.Customers.Find(customerId);
                if (customer != null)
                {
                    _context.Customers.Remove(customer);
                    _context.SaveChanges();
                }
            }
        }
    }
}
