using Abp.AutoMapper;
using SmartUtilities.CitizenProperties.Dtos;
using SmartUtilities.CitizenPropertyUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilitiesCitizenProperties.Dtos
{
    [AutoMapFrom(typeof(CitizenPropertyUser))]
    public class GetPropertyDto
    {
        public CreateUserInputDto User { get; set; }
        public string ErfNo { get; set; }
        public string Type { get; set; }
        //public AddressDto Address { get; set; }
    }
}
