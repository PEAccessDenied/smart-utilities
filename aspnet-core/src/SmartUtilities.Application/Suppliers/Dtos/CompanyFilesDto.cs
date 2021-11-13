using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    public class CompanyFilesDto
    {
        public string FileName { get; set; }
        public string  Type { get; set; }
        public byte[] File { get; set; }
    }
}
