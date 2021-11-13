using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Zones;
using Developmenthub.SmartMetering.Zones.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Resources.Dtos
{
    [AutoMapFrom(typeof(Resource))]
    public class ResourceListDto : FullAuditedEntityDto<Guid>
    {
        public int WardCount { get; set; }
        public string ResourceCategory { get; set; }
        public string ResourceName { get; set; }
        public string ResourceType { get; set; }
        public string Location { get; set; }
        public double Capacity { get; set; }
        public Guid SupplierId { get; set; }
        public ICollection<SupplierZoneResourceListDto> SupplierZoneResources { get; set; } 

    }
}
