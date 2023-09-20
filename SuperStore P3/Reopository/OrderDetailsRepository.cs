using Data;
using Microsoft.EntityFrameworkCore;
using Models;
using EcoPower_Logistics.Data;
using static EcoPower_Logistics.Reopository.OrderDetailsRepository;
namespace EcoPower_Logistics.Reopository
{
    public class OrderDetailsRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        // GET ALL: OrderDetails
        public IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        // TO DO: Add ‘Get By Id’ for OrderDetails
        public OrderDetail GetById(int orderDetailsId)
        {
            return _context.OrderDetails.Find(orderDetailsId);
        }

        // TO DO: Add ‘Create’ for OrderDetails
        public void Create(OrderDetail orderDetail)
        {
            if (orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }

            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        // TO DO: Add ‘Edit’
        public void Edit(OrderDetail orderDetail)
        {
            if (orderDetail == null)
            {
                throw new ArgumentNullException(nameof(orderDetail));
            }

            _context.Entry(orderDetail).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // TO DO: Add ‘Delete’ for OrderDetails
        public void Delete(int orderDetailsId)
        {
            var orderDetail = _context.OrderDetails.Find(orderDetailsId);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
                _context.SaveChanges();
            }
        }

        // TO DO: Add ‘Exists’ for OrderDetails
        public bool Exists(int orderDetailsId)
        {
            return _context.OrderDetails.Any(od => od.OrderDetailsId == orderDetailsId);
        }
    }
}
