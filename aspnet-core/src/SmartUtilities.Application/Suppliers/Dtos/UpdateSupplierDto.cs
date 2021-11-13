using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.Reservoirs.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    [AutoMapFrom(typeof(Supplier))]
    public class UpdateSupplierDto: EntityDto<Guid>
    {
        public string CompanyName { get; set; }
        public int RegNumber { get; set; }
        public virtual string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string CompanyEmailAddress { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual ServiceType ServiceOffered { get; set; }
        public virtual string TaxNumber { get; set; }
        public string DirectLine { get; set; }
        //public virtual string TaxStatus { get; set; }
        public CompanyFilesDto[] CompanyFiles { get; set; }
        public AddressDto Address { get; set; }
        public AddressDto BrancAddress { get; set; }
    }
}
