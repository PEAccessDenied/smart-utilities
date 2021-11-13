using Abp.Domain.Entities.Auditing;
using Developmenthub.SmartMetering.SmartDevices;
using SmartUtilities.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.SmartMeters
{
    public class SmartMeter: FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string MeterNumber { get; set; }
        public string MeterModelNumber { get; set; }
        public string MeterSerialNumber { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public CitizenProperty CitizenProperty { get; set; }
        public Guid PropertyId { get; set; }

        public static SmartMeter AddSmartDevice(Guid deviceId, string name, string modelNumber, string serialNumber, string meterNumber, string meterModelNumber, string meterSerialNumber, Guid propertyId, DeviceType deviceType)
        {
            var device = new SmartMeter
            {
                Id = deviceId,
                Name = name,
                ModelNumber = modelNumber,
                SerialNumber = serialNumber,
                MeterNumber = meterNumber,
                MeterModelNumber = meterModelNumber,
                MeterSerialNumber = meterSerialNumber,
                PropertyId = propertyId,
                DeviceType = deviceType
            };
            return device;
        }
    }
}
