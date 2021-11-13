using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.ServiceWards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Wards.Dto
{
    [AutoMapFrom(typeof(Ward))]
    public class CreateUpdateWardDto :EntityDto<Guid>
    {
        //public string Name { get; set; }
        public int WardNo { get; set; }
        public ICollection<ServiceWard> ServiceWards { get; set; }
    }
}
