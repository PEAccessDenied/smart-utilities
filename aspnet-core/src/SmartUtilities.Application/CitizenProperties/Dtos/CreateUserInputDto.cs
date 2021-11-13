using Abp.AutoMapper;
using Abp.Runtime.Validation;
using SmartUtilities.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties.Dtos
{
    [AutoMapTo(typeof(User))]
    public class CreateUserInputDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNo { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
