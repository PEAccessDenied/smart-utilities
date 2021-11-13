using Abp.AutoMapper;
using Developmenthub.SmartMetering.CitizenProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Wards.Dto
{
    [AutoMapFrom(typeof(Ward))]
    public class WardZoneDto
    {
        public Guid ZoneId { get; set; }
        public Guid WardId { get; set; }
    }
}
