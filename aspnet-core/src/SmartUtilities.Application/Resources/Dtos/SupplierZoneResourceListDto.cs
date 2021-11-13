using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.Zones;
using Developmenthub.SmartMetering.Zones.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Resources.Dtos
{
    [AutoMapFrom(typeof(SupplierZoneResourceListDto))]
    public class SupplierZoneResourceListDto : FullAuditedEntityDto<Guid>
    {
        public ZoneDto Zone { get; set; }
        //public Resource Resource { get; set; }
        public ICollection<Ward> Wards { get; set; }

    }
}
