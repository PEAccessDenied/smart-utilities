using Abp.Domain.Entities.Auditing;
using SmartUtilities.Addresses;
using SmartUtilities.Powerplants;
using SmartUtilities.Reserviors;
using SmartUtilities.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Suppliers
{
    [Table("AppSuppliers")]
    public class Supplier : FullAuditedEntity<Guid>
    {
        public virtual string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string CompanyName { get; set; }
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
        public int RegNumber { get; set; }
        public string DirectLine { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Telephone { get; set; }
        [Required]
        public virtual string CompanyEmailAddress { get; set; }
        public virtual string EmailAddress { get; set; }
        [Required]
        public virtual string TaxNumber { get; set; }
        public virtual string TaxStatus { get; set; }
        public ICollection<PowerPlant> PowerPlants { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<Reservior> Reserviors { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; }
        public Guid? AddressId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public Guid? BranchId { get; set; }

        public static Supplier CreateAsync(string companyName, string telephone, string companyEmailAddress)
        {
            var supplier = new Supplier
            {
                CompanyName = companyName,
                Telephone = telephone,
                CompanyEmailAddress = companyEmailAddress,

            };
            return supplier;
        }
    }
}