using EcoPower_Logistics.Models;

namespace EcoPower_Logistics.Reopository
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }
}