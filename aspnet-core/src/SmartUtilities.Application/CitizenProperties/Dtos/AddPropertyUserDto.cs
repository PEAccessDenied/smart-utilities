using Abp.AutoMapper;
using SmartUtilities.CitizenPropertyUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties.Dtos
{
    [AutoMapFrom(typeof(CitizenPropertyUser))]
    public class AddPropertyUserDto
    {
        public long PropertyOwnerId { get; set; }
        public Guid PropertyId { get; set; }
    }
}
