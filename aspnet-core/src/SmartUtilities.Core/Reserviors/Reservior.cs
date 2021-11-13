using Abp.Domain.Entities.Auditing;
using SmartUtilities.Suppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Reserviors
{
    public class Reservior
    {
        [Table("AppReservoirs")]
        public class Reservior : FullAuditedEntity<Guid>
        {
            [Required]
            public string ResourceCategory { get; set; }
            [Required]
            public string ResourceName { get; set; }
            [Required]
            public string ResourceType { get; set; }
            [Required]
            public string Location { get; set; }

            [Required]
            public double Capacity { get; set; }


            [ForeignKey(nameof(SupplierId))]
            public Supplier Supplier { get; set; }
            public Guid SupplierId { get; set; }
        }
    }
}
