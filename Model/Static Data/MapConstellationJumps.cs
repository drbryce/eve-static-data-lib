using System;
using System.Collections.Generic;

namespace StaticDataHelper.Model
{
    public partial class MapConstellationJumps
    {
        public long? FromRegionId { get; set; }
        public long FromConstellationId { get; set; }
        public long ToConstellationId { get; set; }
        public long? ToRegionId { get; set; }
    }
}
