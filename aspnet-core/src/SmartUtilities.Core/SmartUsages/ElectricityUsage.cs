using Abp.Domain.Entities.Auditing;
using Developmenthub.SmartMetering.CitizenProperties;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Developmenthub.SmartMetering.SmartUsage
{
    [Table("AppElectricityUsage")]
    public class ElectricityUsage : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string MeterNumber { get; set; }
        [ForeignKey(nameof(CitizenPropertyId))]
        public Guid CitizenPropertyId { get; set; }
        public CitizenProperty CitizenProperty { get; set; }
        public int Consumption { get; set; }
        public static int ElectricityUnit { set { ElectricityUnit = 12; } }
    }
}