using Developmenthub.SmartMetering.CitizenProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage.Dtos
{
    public class ListWaterUsage
    {
        public string Name { get; set; }
        public string MeterNumber { get; set; }
        public int Consumption { get; set; }
        public static int WaterCost { set { WaterCost = 12; } }
    }
}
