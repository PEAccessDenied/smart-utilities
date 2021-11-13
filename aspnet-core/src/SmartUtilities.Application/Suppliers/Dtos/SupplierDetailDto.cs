using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SmartUtilities.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Suppliers.Dtos
{
    [AutoMapFrom(typeof(Supplier))]
    public class SupplierDetailDto : EntityDto<Guid>
    {
        //Supplier properties
        public virtual string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string CompanyEmailAddress { get; set; }
        public string CompanyName { get; set; }
        public int RegNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual string TaxNumber { get; set; }
        public virtual string TaxStatus { get; set; }
        public virtual string PhoneNumber { get; set; }
        public string Telephone { get; set; }
        public string DirectLine { get; set; }
        public AddressDto Address { get; set; }
        public string CompanyRegUrl { get; set; }
        public string CompanyRegPublicId { get; set; }
        public string CompanyTaxUrl { get; set; }
        public string CompanyTaxPublicId { get; set; }
        public string CompanyProfileUrl { get; set; }
        public string CompanyProfilePublicId { get; set; }
        public string CompanyBbbeeUrl { get; set; }
        public string CompanyBbbeePublicId { get; set; }
        public string CsdReportUrl { get; set; }
        public string CsdReportPublicId { get; set; }
        //PowerPlant properties
        public ICollection<CreatePowerPlantInput> PowerPlants { get; set; }
        public ICollection<ResourceListDto> Resources { get; set; }
        //Resevoir properties
        public ICollection<CreateReserviorInput> Reserviors { get; set; }
        //Ward properties
        public List<PropertyDetailDto> Properties { get; set; }
    }
}
