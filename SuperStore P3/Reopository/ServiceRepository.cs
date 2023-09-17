using EcoPower_Logistics.Models;
using EcoPower_Logistics.Data;
using SQLitePCL;
using Microsoft.EntityFrameworkCore;
using Data;

namespace EcoPower_Logistics.Reopository
{
    public class ServiceRepository
    {
        private readonly SuperStoreContext _context;

        public ServiceRepository(SuperStoreContext context)
        {
            _context = context;
        }

        // GET ALL: Services
        public IEnumerable<Service> GetAll()
        {
            return (IEnumerable<Service>)_context.Services.ToList();
        }

        // GET BY ID: Service
        

        // CREATE: Service
        

        // EDIT: Service
        public void Edit(Service service)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            _context.Entry(service).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // DELETE: Service by ID
        public void Delete(int id)
        {
            var service = _context.Services.Find(id);
            if (service != null)
            {
                _context.Services.Remove(service);
                _context.SaveChanges();
            }
        }
        // CHECK IF SERVICE EXISTS: by ID
        public bool Exists(int id)
        {
            return _context.Services.Any(s => s.Id == id);
        }
    }
}
