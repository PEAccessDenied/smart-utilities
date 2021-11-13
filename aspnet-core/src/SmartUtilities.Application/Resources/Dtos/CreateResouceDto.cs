using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Resources.Dtos
{
    [AutoMapTo(typeof(Resource))]
    public class CreateResouceDto
    {
        public string ResourceCategory { get; set; }
        public string ResourceName { get; set; }
        public string ResourceType { get; set; }
        public string Location { get; set; }
        public double Capacity { get; set; }
        public Guid SupplierId { get; set; }
        public List<Guid> ZoneIds { get; set; }

    }
}
