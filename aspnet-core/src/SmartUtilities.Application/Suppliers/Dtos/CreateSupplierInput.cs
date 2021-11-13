using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.PowerPlants;
using Developmenthub.SmartMetering.Reservoirs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    [AutoMapFrom(typeof(Supplier))]
    public class CreateSupplierInput 
    {
        public string CompanyName { get; set; }
        public int RegNumber { get; set; }
        public string Telephone { get; set; }
        public string CompanyEmailAddress { get; set; }
        public virtual ServiceType ServiceOffered { get; set; }
    }
}
