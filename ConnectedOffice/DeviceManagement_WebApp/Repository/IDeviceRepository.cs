
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {
        Device GetMostRecentDevice();

    }
}