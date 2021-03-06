﻿using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class ChrAttributes
    {
        public long AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string Description { get; set; }
        public long? IconId { get; set; }
        public string ShortDescription { get; set; }
        public string Notes { get; set; }
    }
}
