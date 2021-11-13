using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Authorization.Users;
using Abp.Extensions;
using SmartUtilities.Addresses;
using SmartUtilities.CitizenPropertyUsers;

namespace SmartUtilities.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        [ForeignKey(nameof(AddressId))]
        public virtual Address Address { get; set; }
        public string IdentityNo { get; set; }
        public Guid? AddressId { get; set; }
        public ICollection<CitizenPropertyUser> Properties { get; set; }
        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
