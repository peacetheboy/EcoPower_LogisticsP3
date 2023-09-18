using System;
using System.Collections.Generic;

namespace EcoPower_Logistics.Reopository
{
    public interface ICustomerRepository
    {
        // Define methods for customer-related data access here

        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerId);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
    }

    // You can also define the Customer class here if it's not already defined elsewhere
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CellPhone { get; set; }
        public string CustomerTitle { get; set; }
    }
}

