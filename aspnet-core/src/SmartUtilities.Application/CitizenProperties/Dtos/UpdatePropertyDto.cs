using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SmartUtilities.Addresses;
using SmartUtilities.Users.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilitiesCitizenProperties
{
    public class UpdatePropertyDto
    {
        public UserDto User { get; set; }
        public string ErfNo { get; set; }
        public string Type { get; set; }
        public AddressDto Address{ get; set; }
    }
}
