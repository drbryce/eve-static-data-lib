﻿using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class RamAssemblyLineTypeDetailPerCategory
    {
        public long AssemblyLineTypeId { get; set; }
        public long CategoryId { get; set; }
        public double? TimeMultiplier { get; set; }
        public double? MaterialMultiplier { get; set; }
        public double? CostMultiplier { get; set; }
    }
}
