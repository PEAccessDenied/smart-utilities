using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SmartUtilities.Powerplants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.PowerPlants
{ 
    [AutoMapTo(typeof(PowerPlant))]
    public class ListPowerPlantDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Usage { get; set; }
        public double Capacity { get; set; }
        //public SupplierDetailDto Supplier { get; set; }
        //public AddressDto Address{ get; set; }
        //public ICollection<Ward> Wards{ get; set; }
    }
}
