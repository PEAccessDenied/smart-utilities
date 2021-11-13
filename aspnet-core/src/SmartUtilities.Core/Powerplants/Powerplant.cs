using Abp.Domain.Entities.Auditing;
using Developmenthub.SmartMetering.SmartUsage;
using SmartUtilities.Addresses;
using SmartUtilities.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Powerplants
{
    [Table("AppPowerPlants")]
    public class PowerPlant : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public double Capacity { get; set; }
        public ICollection<ElectricityUsage> Volume { get; set; }
        //[ForeignKey(nameof(WardId))]
        public ICollection<Ward> Wards { get; set; }
        //public Guid WardId { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public Supplier Supplier { get; set; }
        public Guid SupplierId { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }
        [Required]
        public Guid AddressId { get; set; }

    }
}
