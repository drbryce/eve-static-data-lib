﻿using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class ChrRaces
    {
        public long RaceId { get; set; }
        public string RaceName { get; set; }
        public string Description { get; set; }
        public long? IconId { get; set; }
        public string ShortDescription { get; set; }
    }
}
