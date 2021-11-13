using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    public class WardDetailDto
    {
        public string Name { get; set; }
        public int WardNo { get; set; }
        public int NumberOfProperties { get; set; }
        public double ElectricityConsumption { get; set; }
        public double WaterConsumption { get; set; }
        public double GasConsumption { get; set; }
    }
}
