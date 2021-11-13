using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartDevices.Dtos
{
    [AutoMapFrom(typeof(SmartDevice))]
    public class CreateDeviceDto
    {
        public virtual string Name { get; set; }
        public virtual string ModelNumber { get; set; }
        public virtual string SerialNumber { get; set; }
        public virtual string MeterNumber { get; set; }
        public virtual string MeterModelNumber { get; set; }
        public virtual string MeterSerialNumber { get; set; }
        public virtual Guid PropertyId { get; set; }
        public virtual DeviceType DeviceType { get; set; }
    }
}
