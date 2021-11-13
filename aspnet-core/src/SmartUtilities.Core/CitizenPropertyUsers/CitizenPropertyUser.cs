using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartUtilities.Assets;
using SmartUtilities.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenPropertyUsers
{
    public class CitizenPropertyUser : FullAuditedEntity<Guid>, IMayHaveTenant
    {
        [ForeignKey(nameof(PropertyId))]
        public CitizenProperty Property { get; set; }
        public Guid PropertyId { get; set; }

        [ForeignKey(nameof(PropertyOwnerId))]
        public User User { get; set; }
        public long PropertyOwnerId { get; set; }
        public int? TenantId { get; set; }
    }
}
