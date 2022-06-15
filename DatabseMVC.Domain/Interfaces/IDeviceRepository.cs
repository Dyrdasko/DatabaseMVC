using DatabaseMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Domain.Interfaces
{
    public interface IDeviceRepository
    {
        void DeleteDevice(int deviceId);
        int AddDevice(Device device);
        //IQueryable<Device> GetDeviceByTypeId(int typeId);
        Device GetDeviceById(int deviceId);

    }
}
