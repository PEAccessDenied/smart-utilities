using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage.Dtos
{
    public class ListGasUsageDto
    {

        public string Name { get; set; }
        public string MeterNumber { get; set; }
        public int Consumption { get; set; }
        public static int GasUnit { set { GasUnit = 12; } }
    }
}
