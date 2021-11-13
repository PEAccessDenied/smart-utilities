using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.Suppliers.Dtos
{
    [AutoMapFrom(typeof(Supplier))]
    public class CreateSupplierInput
    {
        public string CompanyName { get; set; }
        public int RegNumber { get; set; }
        public string Telephone { get; set; }
        public string CompanyEmailAddress { get; set; }
    }
}
