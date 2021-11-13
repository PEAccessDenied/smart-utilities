using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartUtilities.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Resources
{
    [Table("AppResources")]
    public class Resource : FullAuditedEntity<Guid>, IMayHaveTenant
    {
        [Required]
        public string ResourceCategory { get; set; }
        [Required]
        public string ResourceName { get; set; }
        [Required]
        public string ResourceType { get; set; }
        public string? Location { get; set; }
        public double? Capacity { get; set; }
        [ForeignKey(nameof(SupplierId))]
        public Supplier Supplier { get; set; }
        public Guid SupplierId { get; set; }
        public int? TenantId { get; set; }

    }
}
