using DatabaseMVC.Domain.Interfaces;
using DatabaseMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMVC.Infrastructure.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly Context _context;
        public DeviceRepository(Context context)
        {
            _context = context;
        }

        public void DeleteDevice(int deviceId)
        {
            var device = _context.Devices.Find(deviceId);
            if (device != null)
            {
                _context.Devices.Remove(device);
                _context.SaveChanges();
            }

        }

        public int AddDevice(Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
            return device.Id;
        }

        //public IQueryable<Device> GetDeviceByTypeId(int typeId)
        //{
        //    var devices = _context.Devices.Where(x => x.TypeId == typeId);
        //    return devices;
        //}

        public Device GetDeviceById(int deviceId)
        {
            var device = _context.Devices.FirstOrDefault(x => x.Id == deviceId);
            return device;
        }
    }
}
