using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.PowerPlants.Dtos
{
    public class SupplierCreateDto
    {
        public virtual string Name { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual string ServiceOffered { get; set; }
        public virtual int TaxNumber { get; set; }
        public virtual string TaxStatus { get; set; }
    }
}
