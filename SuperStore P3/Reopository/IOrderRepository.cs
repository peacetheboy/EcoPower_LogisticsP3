using EcoPower_Logistics.Models;
using static EcoPower_Logistics.Reopository.OrderRepository;

namespace EcoPower_Logistics.Reopository
{
    public interface IOrderRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
        Order GetOrderById(int orderId);
        List<Order> GetAllOrders();
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
    }
}