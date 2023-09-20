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

        // TO DO: Add ‘Get By Id’ for Orders
        public Order GetById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        // TO DO: Add ‘Create’ for Orders
        public void Create(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        // TO DO: Add ‘Edit’ for Orders
        public void Edit(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _context.Entry(order).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // TO DO: Add ‘Delete’ for Orders
        public void Delete(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        // TO DO: Add ‘Exists’ for Orders
        public bool Exists(int orderId)
        {
            return _context.Orders.Any(o => o.OrderId == orderId);
        }
    }
}
