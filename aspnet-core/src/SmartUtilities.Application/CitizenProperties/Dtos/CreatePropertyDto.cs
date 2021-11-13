using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SmartUtilities.Addresses;
using SmartUtilities.Assets;
using SmartUtilities.CitizenProperties.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties
{
    [AutoMapTo(typeof(CitizenProperty))]
    public class CreatePropertyDto
    {
        public CreateUserInputDto User { get; set; } 
        public string ErfNo { get; set; }
        public string Type { get; set; }
        public string BaseUrl { get; set; }
        public int Consumption { get; set; }
        public AddressDto Address { get; set; }
        public Guid WardId { get; set; }
    }
}
