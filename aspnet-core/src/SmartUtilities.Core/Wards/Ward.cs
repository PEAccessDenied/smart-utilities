using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartUtilities.Assets;
using SmartUtilities.Powerplants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmartUtilities.Reserviors.Reserviors;

namespace SmartUtilities.Wards
{

    [Table("AppWards")]
    public class Ward : FullAuditedEntity<Guid>, IMayHaveTenant
    {
        public string Location { get; set; }
        //public ICollection<Address> Addresses { get; set; }
        public int WardNo { get; set; }
        [ForeignKey(nameof(ReservoirId))]
        public Reservior Reservior { get; set; }
        public Guid? ReservoirId { get; set; }
        [ForeignKey(nameof(PowerPlantId))]
        public PowerPlant PowerPlant { get; set; }
        public Guid? PowerPlantId { get; set; }
        public double ServiceRate { get; set; }

        //public Guid? AddressId { get; set; }
        //public Supplier Supplier { get; set; }
        //public Guid? SupplierId { get; set; }
        public int? TenantId { get; set; }
        public ICollection<CitizenProperty> CitizenProperties { get; set; }
        public static Ward CreateAsync(int wardNo, Guid? supplierId, int tenantId)
        {
            var ward = new Ward
            {
                //Name = name,
                WardNo = wardNo,
                //SupplierId = supplierId,
                TenantId = tenantId
            };
            return ward;
        }
    }
}
