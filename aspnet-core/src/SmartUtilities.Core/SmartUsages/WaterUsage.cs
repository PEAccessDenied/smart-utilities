using Abp.Domain.Entities.Auditing;
using Developmenthub.SmartMetering.CitizenProperties;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Developmenthub.SmartMetering.SmartUsage
{
    [Table("AppWaterUsages")]
    public class WaterUsage: FullAuditedEntity<Guid>
    {
        public string MeterNumber { get; set; }
        [ForeignKey(nameof(CitizenPropertyId))]
        public Guid CitizenPropertyId { get; set; }
        public CitizenProperty CitizenProperty { get; set; }
        public int Consumption { get; set; }
        public static int WaterCost { set { WaterCost = 12; } }
    }
}