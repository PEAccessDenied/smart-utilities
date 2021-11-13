using Abp.AutoMapper;
using Developmenthub.SmartMetering.Authorization.Users;
using Developmenthub.SmartMetering.CitizenPropertyUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties.Dtos
{
    [AutoMapFrom(typeof(CitizenPropertyUser))]
    public class AddPropertyUserDto
    {
        public long PropertyOwnerId { get; set; }
        public Guid PropertyId { get; set; }
    }
}
