using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartUtilities.Addresses
{
    [Table("AppAddress")]
    public class Address : FullAuditedEntity<Guid>
    {
        [Required]
        public virtual string Line1 { get; set; }
        public virtual string Line2 { get; set; }
        [Required]
        public virtual string City { get; set; }
        [Required]
        public virtual int PostalCode { get; set; }
        public string Province { get; set; }
        [ForeignKey(nameof(WardId))]
        public virtual Guid? WardId { get; set; }
        public Ward Ward { get; set; }
    }
}