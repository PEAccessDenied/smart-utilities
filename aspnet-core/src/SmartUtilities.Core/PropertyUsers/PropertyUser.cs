using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.PropertyUsers
{
    [Table("AppPropertyUser")]
    public class PropertyUser
    {
        [ForeignKey(nameof(PropertyId))]
        public Property Property { get; set; }
        public Guid PropertyId { get; set; }

        [ForeignKey(nameof(PropertyOwnerId))]
        public User User { get; set; }
        public long PropertyOwnerId { get; set; }
        public int? TenantId { get; set; }
    }
}
