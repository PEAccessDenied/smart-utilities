using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SmartUtilities.Addresses;
using SmartUtilities.CitizenPropertyUsers;
using SmartUtilities.SmartMeters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Assets
{
    [Table("AppCitizenProperties")]
    public class CitizenProperty : FullAuditedEntity<Guid>, IMayHaveTenant
    {
        public string Type { get; set; }
        [ForeignKey(nameof(AddressId))]
        public Guid? AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<CitizenPropertyUser> PropertyUsers { get; set; }
        public ICollection<SmartMeter> PropertyDevices { get; set; }
        [Required]
        public string ErfNo { get; set; }
        //public ICollection<WaterUsage> WaterUsage { get; set; }
        //public ICollection<ElectricityUsage> ElectricityUsage { get; set; }
        public int? TenantId { get; set; }
        [Required]
        [ForeignKey(nameof(WardId))]
        public Guid WardId { get; set; }
        public Ward Ward { get; set; }

        public int Consumption { get; set; }
        public static CitizenProperty AddProperty(Guid propertyId, Guid addressId, string erfNo, Guid wardId, int consumption)
        {
            /** First check if Identity of the citizen is valid and if indeed owns the property
             * Implement that below
             **/
            var property = new CitizenProperty
            {
                Id = propertyId,
                AddressId = addressId,
                ErfNo = erfNo,
                WardId = wardId,
                Consumption = consumption
            };
            return property;
        }
    }
}
