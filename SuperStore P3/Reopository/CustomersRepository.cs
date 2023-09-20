using Data;
using EcoPower_Logistics.Data;
using Microsoft.EntityFrameworkCore;
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
        public Customer GetById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        // TO DO: Add ‘Create’
        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        // TO DO: Add ‘Edit’
        public void Edit(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // TO DO: Add ‘Delete’
        public void Delete(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        // TO DO: Add ‘Exists’
        public bool Exists(int customerId)
        {
            return _context.Customers.Any(c => c.CustomerId == customerId);
        }

    }
}