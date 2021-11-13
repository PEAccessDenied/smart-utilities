using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.ServiceWards;
using Developmenthub.SmartMetering.Wards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties
{
    [AutoMapFrom(typeof(Ward))]
    public class WardDto: EntityDto<Guid>
    {
        //public string Name { get; set; }
        public int WardNo { get; set; }
        public string Location { get; set; }
        public Guid? ReservoirId { get; set; }
        public Guid? PowerPlantId { get; set; }
        public double ServiceRate { get; set; }
        public Guid? ZoneId { get; set; }
        public int PropertyCount { get; set; }
        public ICollection<ServiceWard> ServiceWards { get; set; }
    }
}
