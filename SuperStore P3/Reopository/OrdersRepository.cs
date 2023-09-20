using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using Controllers;
using EcoPower_Logistics.Data;
using static EcoPower_Logistics.Reopository.OrdersRepository;

namespace EcoPower_Logistics.Reopository
{
    public class OrdersRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        // GET ALL: Orders
        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }
}
