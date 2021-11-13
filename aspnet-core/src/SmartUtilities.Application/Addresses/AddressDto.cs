using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Addresses
{
    [AutoMapTo(typeof(AddressDto))]
    public class AddressDto
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public int PostalCode { get; set; }
        public int PoBox { get; set; }
    }
}
