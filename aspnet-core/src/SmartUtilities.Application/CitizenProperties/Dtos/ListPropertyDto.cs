using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SmartUtilities.Addresses;
using SmartUtilities.Assets;
using SmartUtilities.CitizenProperties.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties
{
    [AutoMapFrom(typeof(CitizenProperty))]
    public class ListPropertyDto : FullAuditedEntityDto<Guid>
    {
        public string Type { get; set; }
        public ICollection<CitizenPropertyUserDto> PropertyUsers { get; set; }
        public AddressDto Address { get; set; }
        public string ErfNo { get; set; }
        public int Consumption { get; set; }
    }
}
