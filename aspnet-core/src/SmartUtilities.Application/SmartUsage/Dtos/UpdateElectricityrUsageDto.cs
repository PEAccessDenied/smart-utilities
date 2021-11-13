﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage.Dtos
{
    public class UpdateElectricityrUsageDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string MeterNumber { get; set; }
        public int Consumption { get; set; }
        public static int ElectricityUnit { set { ElectricityUnit = 12; } }
    }
}
