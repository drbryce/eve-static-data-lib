﻿using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvPositions
    {
        public long ItemId { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double? Yaw { get; set; }
        public double? Pitch { get; set; }
        public double? Roll { get; set; }
    }
}
