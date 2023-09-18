using EcoPower_Logistics.Models;
using EcoPower_Logistics.Data;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using Data;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Reopository
{
    public class Order
    {
        public int OrderId { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public DateTime OrderDate { get; set; }
    }

    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; } = null!;
    }

    public class OrderRepository
    {
        private readonly OrderContext context;

        public OrderRepository()
        {
            context = new OrderContext();
        }

        public List<Order> GetAllOrders()
        {
            return context.Orders.ToList();
        }

        public Order GetOrderById(int orderId)
        {
            return context.Orders.Find(orderId);
        }

        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public bool UpdateOrder(int orderId, Order updatedOrderData)
        {
            var existingOrder = context.Orders.Find(orderId);
            if (existingOrder != null)
            {
                existingOrder.OrderId = updatedOrderData.OrderId;
                existingOrder.OrderDate = updatedOrderData.OrderDate;
                existingOrder.DeliveryAddress = updatedOrderData.DeliveryAddress;

                context.Entry(existingOrder).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public void DeleteOrder(int orderId)
        {
            var order = context.Orders.Find(orderId);
            if (order != null)
            {
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }
    }
}
