using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage.Dtos
{
    public class GasUsageDto
    {
        public string Name { get; set; }
        public string MeterNumber { get; set; }
        public int Consumption { get; set; }
        public static int GasCost { set { GasCost = 12; } }
    }
}
