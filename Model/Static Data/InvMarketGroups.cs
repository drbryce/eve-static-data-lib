﻿using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class InvMarketGroups
    {
        public long MarketGroupId { get; set; }
        public long? ParentGroupId { get; set; }
        public string MarketGroupName { get; set; }
        public string Description { get; set; }
        public long? IconId { get; set; }
        public string HasTypes { get; set; }
    }
}
